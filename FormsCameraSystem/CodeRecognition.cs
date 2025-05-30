using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCameraSystem
{
    public class CodeRecognition
    {
        public int CodeCount { get; private set; }
        public Rectangle ROI { get; private set; }

        public void SetCodeCount(int count)
        {
            CodeCount = count;
        }

        public int GetCodeCount()
        {
            return CodeCount;
        }

        public void SetROI(Rectangle region)
        {
            ROI = region;
        }

        public Rectangle GetROI()
        {
            return ROI;
        }

        public void RecognizeCodes(byte[][] image)
        {
            // Логика распознавания кодов в изображении
        }
    }
}
