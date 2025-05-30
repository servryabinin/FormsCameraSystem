using SmartCameraLibrary;
using SmartCameraLibrary.CodeWorker;


namespace FormsCameraSystem
{
    public partial class Form1 : Form
    {
        private SmartCameraLibrary.SmartCameraSystem smartCameraSystem;
        private SmartCameraLibrary.CameraSettings cameraSettings;
        private SmartCameraLibrary.Camera camera;
        //private SmartCameraLibrary.CodeRecognition codeRecognintion;
        private bool isVideoStreaming = false;
        private byte recognizeCodeFlag = 0x00;
        private byte codeType = 0x00;
        private bool isGradeShowFlag;
        private int generalGradeValue;
        private bool isNetworkFrames;
        private bool isLiveVideo;


        public Form1()
        {
            InitializeComponent();
            smartCameraSystem = new SmartCameraSystem("192.168.0.128", 50000);
            smartCameraSystem.ImageReceived += OnImageReceived;
            smartCameraSystem.CodeReceived += OnCodeReceived;
            smartCameraSystem.ErrorReceived += OnErrorReceived;
            smartCameraSystem.FrameReceived += OnFrameReceived;

            // Инициализация cameraSettings
            cameraSettings = new SmartCameraLibrary.CameraSettings();
        }


        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                await smartCameraSystem.Connect();
                MessageBox.Show("Подключение к камере успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подключении к камере: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetImage_Click(object sender, EventArgs e)
        {



            try
            {
                await smartCameraSystem.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnImageReceived(object sender, Bitmap image)
        {
            ImagePictureBox.Invoke(new Action(() =>
            {
                ImagePictureBox.Image = image;
            }));
        }

        private void OnCodeReceived(object sender, Code code)
        {
            // Формируем вывод для PackageTextBox с полной информацией о коде
            string infoMessage = code.CodeToString();  // Преобразуем объект Code в строку с полной информацией
            
            // Выводим значения в соответствующие текстовые поля
            contentCodeTextBox.Invoke(new Action(() =>
            {
                contentCodeTextBox.Text = code.Content;  // Выводим содержимое кода
            }));

            codeTypeRecognizeTextBox.Invoke(new Action(() =>
            {
                codeTypeRecognizeTextBox.Text = code.CodeType.ToString();  // Выводим тип кода
            }));

            mainCoordinateTextBox.Invoke(new Action(() =>
            {
                mainCoordinateTextBox.Text = $"X: {code.Location.X}, Y: {code.Location.Y}";  // Выводим главные координаты
            }));

            addtitonalCoordinateTextBox.Invoke(new Action(() =>
            {
                addtitonalCoordinateTextBox.Text = $"X1: {code.AdditionalLocation.X1}, Y1: {code.AdditionalLocation.Y1}";  // Выводим дополнительные координаты
            }));

            // Отдельный вывод значения Grade в Label_GRD
            Label_GRD.Invoke(new Action(() =>
            {
                Label_GRD.Text = code.Grade.ToString();  // Выводим грейд в Label_GRD
            }));
        }


        // Метод для извлечения грейда из строки
        private string ExtractGrade(string infoMessage)
        {
            // Предположим, что информация о грейде представлена в формате "Grade: X", где X - это грейд
            string gradePattern = @"Grade: (\w)";
            var match = System.Text.RegularExpressions.Regex.Match(infoMessage, gradePattern);

            if (match.Success)
            {
                // Возвращаем найденный грейд (например, "A", "B", и т.д.)
                return match.Groups[1].Value;
            }

            // Если грейд не найден, возвращаем пустую строку
            return string.Empty;
        }



        private void OnErrorReceived(object sender, string errorMessage)
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void StartVideoButton_Click_1(object sender, EventArgs e)
        {
            smartCameraSystem.DmxInit();
            string selectedCodeName = comboBox1.SelectedItem?.ToString();
            int selectedTrigerActivationType = trigerActivationTypeCheckBox.SelectedIndex;
            isLiveVideo = true;
            if (!isVideoStreaming)
            {
                smartCameraSystem.UpdateSettings(
                   int.Parse(WidthTextBox.Text),
                   int.Parse(HeightTextBox.Text),
                   int.Parse(ExpositionTextBox.Text),
                   int.Parse(FocusTextBox.Text),
                   int.Parse(DYTextBox.Text),
                   int.Parse(DXTextBox.Text),
                   int.Parse(UDPDelayTextBox.Text),
                   recognizeCodeFlag,
                   selectedCodeName,
                   NetworkFrames.Checked,
                   isLiveVideo,
                   trigerCheckBox.Checked,
                   lightModCheckBox.Checked);

                isVideoStreaming = true;
                smartCameraSystem.StartVideoStream();
            }
        }

        private async void EndVideoStream_Click(object sender, EventArgs e)
        {
            isLiveVideo = false;
            if (isVideoStreaming)
            {
                isVideoStreaming = false;
                await smartCameraSystem.EndVideoStream();
                ImagePictureBox.Image = null;
            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Camera Settings";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    smartCameraSystem.SaveSettings(filePath);
                    MessageBox.Show($"Настройки успешно сохранены в файл: {filePath}", "Сохранение настроек", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoadSettingsButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                openFileDialog.Title = "Open Camera Settings";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    smartCameraSystem.LoadSettings(filePath);

                    WidthTextBox.Text = smartCameraSystem.ImageWidth.ToString();
                    HeightTextBox.Text = smartCameraSystem.ImageHeight.ToString();
                    ExpositionTextBox.Text = smartCameraSystem.ImageExposition.ToString();
                    FocusTextBox.Text = smartCameraSystem.ImageFocus.ToString();
                    DYTextBox.Text = smartCameraSystem.RoiDY.ToString();
                    DXTextBox.Text = smartCameraSystem.RoiDX.ToString();
                    UDPDelayTextBox.Text = smartCameraSystem.UdpDelay.ToString();
                }
            }
        }

        private async void RecognizeCodeButton_Click(object sender, EventArgs e)
        {
            recognizeCheckBox.Checked = true;
            string selectedCodeName = comboBox1.SelectedItem?.ToString();
            try
            {
                smartCameraSystem.RecognizeCode(selectedCodeName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при распознавании кода: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EndRecognizeCodeButton_Click(object sender, EventArgs e)
        {
            recognizeCheckBox.Checked = false;
            smartCameraSystem.EndRecognizeCode();
        }

        private async void ApplySettings_Click(object sender, EventArgs e)
        {
            string selectedCodeName = comboBox1.SelectedItem?.ToString();
            if (cameraSettings == null)
            {
                MessageBox.Show("Настройки камеры не инициализированы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Обновляем настройки камеры
                smartCameraSystem.UpdateSettings(
                    int.Parse(WidthTextBox.Text),
                    int.Parse(HeightTextBox.Text),
                    int.Parse(ExpositionTextBox.Text),
                    int.Parse(FocusTextBox.Text),
                    int.Parse(DYTextBox.Text),
                    int.Parse(DXTextBox.Text),
                    int.Parse(UDPDelayTextBox.Text),
                    recognizeCodeFlag,
                    selectedCodeName,
                    NetworkFrames.Checked,
                    isLiveVideo,
                    trigerCheckBox.Checked,
                   lightModCheckBox.Checked);



                // Получаем изображение с новыми параметрами
                await smartCameraSystem.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при применении настроек: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Освобождение ресурсов при закрытии формы
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            camera?.Dispose(); // Освобождаем объект Camera при закрытии формы
        }

        private void ButtonGradeShow_Click(object sender, EventArgs e)
        {
            gradeShow.Checked = true;
            generalGradeValue = comboBox3.SelectedIndex;
            smartCameraSystem.StartShowGrade(generalGradeValue);

        }

        private void ButtonGradeEndShow_Click(object sender, EventArgs e)
        {
            gradeShow.Checked = false;
            smartCameraSystem.StopShowGrade();
        }

        private void ButtonStartHighlightDatamatrix_Click(object sender, EventArgs e)
        {
            checkBoxHighlight.Checked = true;
            smartCameraSystem.StartHighlightDatamatrix();
        }

        private void ButtonStopHighlightDatamatrix_Click(object sender, EventArgs e)
        {
            checkBoxHighlight.Checked = false;
            smartCameraSystem.StopHighlightDatamatrix();
        }

        // Метод, который вызывается при получении нового кадра
        private void OnFrameReceived(object sender, int frameNumber)
        {
            // Обновляем текстовое поле FpsTextBox в главном потоке
            this.Invoke((MethodInvoker)delegate
            {
                FpsTextBox.Text = frameNumber.ToString();
            });
        }

        private void ButtonTrigerOn_Click(object sender, EventArgs e)
        {
            trigerCheckBox.Checked = true;
            int selectedTrigerActivationTypeIndex = trigerActivationTypeCheckBox.SelectedIndex;
            smartCameraSystem.StartTriger(selectedTrigerActivationTypeIndex);
        }

        private void ButtonTriggerOff_Click(object sender, EventArgs e)
        {
            trigerCheckBox.Checked = false;
            smartCameraSystem.StopTriger();
        }

        private void ButtonLightModOn_Click(object sender, EventArgs e)
        {
            lightModCheckBox.Checked = true;
            smartCameraSystem.StartLightMod();
        }

        private void ButtonLightModOff_Click(object sender, EventArgs e)
        {
            lightModCheckBox.Checked = false;
            smartCameraSystem.StopLightMod();
        }

        private void contentCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
