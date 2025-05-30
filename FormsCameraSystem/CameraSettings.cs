using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace FormsCameraSystem
{
    public class CameraSettings
    {
        public int ImageWidth { get; set; } = 800;
        public int ImageHeight { get; set; } = 800;
        public int ImageExposition { get; set; } = 3000;
        public int ImageFocus { get; set; } = 20;
        public int RoiDY { get; set; } = 0;
        public int RoiDX { get; set; } = 0;
        public int UdpDelay { get; set; } = 700;

        public byte RecognizeCodeFlag { get; set; } = 0x00;


        public void UpdateSettings(TextBox widthTextBox, TextBox heightTextBox, TextBox expositionTextBox, TextBox focusTextBox, TextBox dyTextBox, TextBox dxTextBox, TextBox udpDelayTextBox, byte recognizeCodeFlag)
        {
            ImageWidth = int.TryParse(widthTextBox.Text, out var w) ? w : ImageWidth;
            ImageHeight = int.TryParse(heightTextBox.Text, out var h) ? h : ImageHeight;
            ImageExposition = int.TryParse(expositionTextBox.Text, out var exp) ? exp : ImageExposition;
            ImageFocus = int.TryParse(focusTextBox.Text, out var focus) ? focus : ImageFocus;
            RoiDY = int.TryParse(dyTextBox.Text, out var dy) ? dy : RoiDY;
            RoiDX = int.TryParse(dxTextBox.Text, out var dx) ? dx : RoiDX;
            UdpDelay = int.TryParse(udpDelayTextBox.Text, out var delay) ? delay : UdpDelay;
            RecognizeCodeFlag = recognizeCodeFlag; // устанавливаем recognizeCodeFlag
        }


        public void SaveSettings(string filePath)
        {
            var json = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, json);
        }

        public void LoadSettings(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var settings = JsonSerializer.Deserialize<CameraSettings>(json);

                if (settings != null)
                {
                    ImageWidth = settings.ImageWidth;
                    ImageHeight = settings.ImageHeight;
                    ImageExposition = settings.ImageExposition;
                    ImageFocus = settings.ImageFocus;
                    RoiDY = settings.RoiDY;
                    RoiDX = settings.RoiDX;
                    UdpDelay = settings.UdpDelay;
                }
            }
            else
            {
                MessageBox.Show("Файл настроек не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
