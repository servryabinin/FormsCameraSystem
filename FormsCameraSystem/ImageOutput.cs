using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Diagnostics;


namespace FormsCameraSystem
{
    public class ImageOutput
    {
        private PictureBox imagePictureBox;
        private int imageWidth;
        private int imageHeight;

        public ImageOutput(PictureBox pictureBox, int width, int height)
        {
            imagePictureBox = pictureBox;
            imageWidth = width;
            imageHeight = height;
        }

        public void DisplayImage(byte[][] imageBuffer)
        {
            // Создаем и запускаем секундомер
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (Bitmap bitmap = new Bitmap(imageWidth, imageHeight, PixelFormat.Format24bppRgb))
            {
                BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, imageWidth, imageHeight), ImageLockMode.WriteOnly, bitmap.PixelFormat);
                IntPtr ptr = bmpData.Scan0;
                int bytes = Math.Abs(bmpData.Stride) * imageHeight;
                byte[] rgbValues = new byte[bytes];

                Parallel.For(0, imageHeight, i =>
                {
                    if (imageBuffer[i] != null)
                    {
                        for (int j = 0; j < imageWidth; j++)
                        {
                            int index = i * bmpData.Stride + j * 3;
                            byte pixelValue = imageBuffer[i][j];
                            rgbValues[index] = pixelValue;
                            rgbValues[index + 1] = pixelValue;
                            rgbValues[index + 2] = pixelValue;
                        }
                    }
                });

                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
                bitmap.UnlockBits(bmpData);

                imagePictureBox.Invoke(new Action(() =>
                {
                    imagePictureBox.Image = (Bitmap)bitmap.Clone();
                    imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }));
            }
        }

    }

}
