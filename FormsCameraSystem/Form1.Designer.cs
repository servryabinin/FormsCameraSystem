namespace FormsCameraSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      panel1 = new Panel();
      ApplySettings = new Button();
      LoadSettingsButton = new Button();
      SaveSettingsButton = new Button();
      ConnectButton = new Button();
      EndVideoStream = new Button();
      StartVideoButton = new Button();
      PackageTextBox = new TextBox();
      ImagePictureBox = new PictureBox();
      WidthTextBox = new TextBox();
      HeightTextBox = new TextBox();
      WidthLabel = new Label();
      HeightLabel = new Label();
      expositionLabel = new Label();
      ExpositionTextBox = new TextBox();
      focusLabel = new Label();
      FocusTextBox = new TextBox();
      ImageWorker = new GroupBox();
      FrameParam = new GroupBox();
      NetworkFrames = new CheckBox();
      FpsTextBox = new TextBox();
      UDPDelay = new Label();
      UDPDelayTextBox = new TextBox();
      Fps = new Label();
      InterestArea = new GroupBox();
      DXlabel = new Label();
      DXTextBox = new TextBox();
      DYlabel = new Label();
      DYTextBox = new TextBox();
      CodeRecognition = new GroupBox();
      recognizeCheckBox = new CheckBox();
      checkBoxHighlight = new CheckBox();
      ButtonStopHighlightDatamatrix = new Button();
      label10 = new Label();
      ButtonStartHighlightDatamatrix = new Button();
      EndRecognizeCodeButton = new Button();
      comboBox1 = new ComboBox();
      RecognizeCodeButton = new Button();
      CodeChoose = new Label();
      CodeData = new Label();
      groupBox1 = new GroupBox();
      ButtonGradeEndShow = new Button();
      ButtonGradeShow = new Button();
      label9 = new Label();
      label8 = new Label();
      label7 = new Label();
      label6 = new Label();
      label5 = new Label();
      label4 = new Label();
      label3 = new Label();
      label2 = new Label();
      label1 = new Label();
      gradeShow = new CheckBox();
      comboBox3 = new ComboBox();
      Label_GRD = new TextBox();
      G7 = new TextBox();
      G6 = new TextBox();
      G5 = new TextBox();
      G4 = new TextBox();
      G3 = new TextBox();
      G2 = new TextBox();
      G1 = new TextBox();
      G0 = new TextBox();
      groupBox2 = new GroupBox();
      label11 = new Label();
      trigerActivationTypeCheckBox = new ComboBox();
      lightModCheckBox = new CheckBox();
      trigerCheckBox = new CheckBox();
      ButtonLightModOff = new Button();
      ButtonLightModOn = new Button();
      ButtonTriggerOff = new Button();
      ButtonTrigerOn = new Button();
      groupBox3 = new GroupBox();
      addtitonalCoordinateTextBox = new TextBox();
      label15 = new Label();
      contentCodeTextBox = new TextBox();
      label14 = new Label();
      mainCoordinateTextBox = new TextBox();
      label13 = new Label();
      codeTypeRecognizeTextBox = new TextBox();
      label12 = new Label();
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ImagePictureBox).BeginInit();
      ImageWorker.SuspendLayout();
      FrameParam.SuspendLayout();
      InterestArea.SuspendLayout();
      CodeRecognition.SuspendLayout();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      groupBox3.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackColor = SystemColors.Info;
      panel1.BorderStyle = BorderStyle.Fixed3D;
      panel1.Controls.Add(ApplySettings);
      panel1.Controls.Add(LoadSettingsButton);
      panel1.Controls.Add(SaveSettingsButton);
      panel1.Controls.Add(ConnectButton);
      panel1.Location = new Point(1, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(1330, 46);
      panel1.TabIndex = 0;
      // 
      // ApplySettings
      // 
      ApplySettings.BackColor = SystemColors.ScrollBar;
      ApplySettings.Location = new Point(149, 5);
      ApplySettings.Name = "ApplySettings";
      ApplySettings.Size = new Size(232, 34);
      ApplySettings.TabIndex = 4;
      ApplySettings.Text = "Применить настройки";
      ApplySettings.UseVisualStyleBackColor = false;
      ApplySettings.Click += ApplySettings_Click;
      // 
      // LoadSettingsButton
      // 
      LoadSettingsButton.BackColor = SystemColors.ScrollBar;
      LoadSettingsButton.Location = new Point(616, 5);
      LoadSettingsButton.Name = "LoadSettingsButton";
      LoadSettingsButton.Size = new Size(222, 34);
      LoadSettingsButton.TabIndex = 3;
      LoadSettingsButton.Text = "Загрузить настройки";
      LoadSettingsButton.UseVisualStyleBackColor = false;
      LoadSettingsButton.Click += LoadSettingsButton_Click;
      // 
      // SaveSettingsButton
      // 
      SaveSettingsButton.BackColor = SystemColors.ScrollBar;
      SaveSettingsButton.Location = new Point(388, 5);
      SaveSettingsButton.Name = "SaveSettingsButton";
      SaveSettingsButton.Size = new Size(222, 34);
      SaveSettingsButton.TabIndex = 2;
      SaveSettingsButton.Text = "Сохранить параметры";
      SaveSettingsButton.UseVisualStyleBackColor = false;
      SaveSettingsButton.Click += SaveSettingsButton_Click;
      // 
      // ConnectButton
      // 
      ConnectButton.BackColor = SystemColors.ScrollBar;
      ConnectButton.Location = new Point(4, 5);
      ConnectButton.Name = "ConnectButton";
      ConnectButton.Size = new Size(137, 34);
      ConnectButton.TabIndex = 0;
      ConnectButton.Text = "Подключение";
      ConnectButton.UseVisualStyleBackColor = false;
      ConnectButton.Click += ConnectButton_Click;
      // 
      // EndVideoStream
      // 
      EndVideoStream.BackColor = Color.Red;
      EndVideoStream.Location = new Point(6, 151);
      EndVideoStream.Name = "EndVideoStream";
      EndVideoStream.Size = new Size(126, 104);
      EndVideoStream.TabIndex = 3;
      EndVideoStream.Text = "Прекратить видеопоток";
      EndVideoStream.UseVisualStyleBackColor = false;
      EndVideoStream.Click += EndVideoStream_Click;
      // 
      // StartVideoButton
      // 
      StartVideoButton.BackColor = Color.Lime;
      StartVideoButton.Location = new Point(6, 35);
      StartVideoButton.Name = "StartVideoButton";
      StartVideoButton.Size = new Size(126, 110);
      StartVideoButton.TabIndex = 2;
      StartVideoButton.Text = "Получить видеопоток";
      StartVideoButton.UseVisualStyleBackColor = false;
      StartVideoButton.Click += StartVideoButton_Click_1;
      // 
      // PackageTextBox
      // 
      PackageTextBox.Location = new Point(405, 505);
      PackageTextBox.Multiline = true;
      PackageTextBox.Name = "PackageTextBox";
      PackageTextBox.ScrollBars = ScrollBars.Vertical;
      PackageTextBox.Size = new Size(544, 224);
      PackageTextBox.TabIndex = 1;
      // 
      // ImagePictureBox
      // 
      ImagePictureBox.BackColor = SystemColors.ButtonHighlight;
      ImagePictureBox.BorderStyle = BorderStyle.Fixed3D;
      ImagePictureBox.Image = (Image)resources.GetObject("ImagePictureBox.Image");
      ImagePictureBox.Location = new Point(405, 52);
      ImagePictureBox.Name = "ImagePictureBox";
      ImagePictureBox.Size = new Size(544, 418);
      ImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
      ImagePictureBox.TabIndex = 2;
      ImagePictureBox.TabStop = false;
      // 
      // WidthTextBox
      // 
      WidthTextBox.Location = new Point(15, 125);
      WidthTextBox.Name = "WidthTextBox";
      WidthTextBox.Size = new Size(70, 27);
      WidthTextBox.TabIndex = 3;
      WidthTextBox.Text = "1000";
      // 
      // HeightTextBox
      // 
      HeightTextBox.Location = new Point(118, 125);
      HeightTextBox.Name = "HeightTextBox";
      HeightTextBox.Size = new Size(70, 27);
      HeightTextBox.TabIndex = 4;
      HeightTextBox.Text = "1000";
      // 
      // WidthLabel
      // 
      WidthLabel.AutoSize = true;
      WidthLabel.Location = new Point(15, 102);
      WidthLabel.Name = "WidthLabel";
      WidthLabel.Size = new Size(70, 20);
      WidthLabel.TabIndex = 5;
      WidthLabel.Text = "Ширина:";
      // 
      // HeightLabel
      // 
      HeightLabel.AutoSize = true;
      HeightLabel.Location = new Point(118, 102);
      HeightLabel.Name = "HeightLabel";
      HeightLabel.Size = new Size(62, 20);
      HeightLabel.TabIndex = 6;
      HeightLabel.Text = "Высота:";
      // 
      // expositionLabel
      // 
      expositionLabel.AutoSize = true;
      expositionLabel.Location = new Point(108, 169);
      expositionLabel.Name = "expositionLabel";
      expositionLabel.Size = new Size(95, 20);
      expositionLabel.TabIndex = 8;
      expositionLabel.Text = "Экспозиция:";
      // 
      // ExpositionTextBox
      // 
      ExpositionTextBox.Location = new Point(112, 192);
      ExpositionTextBox.Name = "ExpositionTextBox";
      ExpositionTextBox.Size = new Size(79, 27);
      ExpositionTextBox.TabIndex = 7;
      ExpositionTextBox.Text = "3000";
      // 
      // focusLabel
      // 
      focusLabel.AutoSize = true;
      focusLabel.Location = new Point(15, 169);
      focusLabel.Name = "focusLabel";
      focusLabel.Size = new Size(53, 20);
      focusLabel.TabIndex = 10;
      focusLabel.Text = "Фокус:";
      // 
      // FocusTextBox
      // 
      FocusTextBox.Location = new Point(15, 192);
      FocusTextBox.Name = "FocusTextBox";
      FocusTextBox.Size = new Size(70, 27);
      FocusTextBox.TabIndex = 9;
      FocusTextBox.Text = "20";
      // 
      // ImageWorker
      // 
      ImageWorker.BackColor = SystemColors.ControlLightLight;
      ImageWorker.BackgroundImageLayout = ImageLayout.None;
      ImageWorker.Controls.Add(FrameParam);
      ImageWorker.Controls.Add(EndVideoStream);
      ImageWorker.Controls.Add(InterestArea);
      ImageWorker.Controls.Add(StartVideoButton);
      ImageWorker.FlatStyle = FlatStyle.Popup;
      ImageWorker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
      ImageWorker.Location = new Point(12, 55);
      ImageWorker.Name = "ImageWorker";
      ImageWorker.Size = new Size(372, 415);
      ImageWorker.TabIndex = 11;
      ImageWorker.TabStop = false;
      ImageWorker.Text = "Сенсор";
      // 
      // FrameParam
      // 
      FrameParam.BackColor = SystemColors.ButtonHighlight;
      FrameParam.Controls.Add(NetworkFrames);
      FrameParam.Controls.Add(FpsTextBox);
      FrameParam.Controls.Add(UDPDelay);
      FrameParam.Controls.Add(UDPDelayTextBox);
      FrameParam.Controls.Add(Fps);
      FrameParam.Location = new Point(14, 270);
      FrameParam.Name = "FrameParam";
      FrameParam.Size = new Size(335, 125);
      FrameParam.TabIndex = 13;
      FrameParam.TabStop = false;
      FrameParam.Text = "Параметры кадров";
      // 
      // NetworkFrames
      // 
      NetworkFrames.AutoSize = true;
      NetworkFrames.BackColor = SystemColors.ButtonHighlight;
      NetworkFrames.Checked = true;
      NetworkFrames.CheckState = CheckState.Checked;
      NetworkFrames.Location = new Point(18, 26);
      NetworkFrames.Name = "NetworkFrames";
      NetworkFrames.Size = new Size(132, 24);
      NetworkFrames.TabIndex = 13;
      NetworkFrames.Text = "Кадры по сети";
      NetworkFrames.UseVisualStyleBackColor = false;
      // 
      // FpsTextBox
      // 
      FpsTextBox.Location = new Point(18, 78);
      FpsTextBox.Name = "FpsTextBox";
      FpsTextBox.Size = new Size(70, 27);
      FpsTextBox.TabIndex = 11;
      // 
      // UDPDelay
      // 
      UDPDelay.AutoSize = true;
      UDPDelay.Location = new Point(184, 55);
      UDPDelay.Name = "UDPDelay";
      UDPDelay.Size = new Size(112, 20);
      UDPDelay.TabIndex = 12;
      UDPDelay.Text = "Задержка UDP:";
      // 
      // UDPDelayTextBox
      // 
      UDPDelayTextBox.Location = new Point(189, 78);
      UDPDelayTextBox.Name = "UDPDelayTextBox";
      UDPDelayTextBox.Size = new Size(95, 27);
      UDPDelayTextBox.TabIndex = 11;
      UDPDelayTextBox.Text = "700";
      // 
      // Fps
      // 
      Fps.AutoSize = true;
      Fps.Location = new Point(18, 55);
      Fps.Name = "Fps";
      Fps.Size = new Size(146, 20);
      Fps.TabIndex = 12;
      Fps.Text = "Количество кадров:";
      // 
      // InterestArea
      // 
      InterestArea.BackColor = SystemColors.ButtonHighlight;
      InterestArea.Controls.Add(DXlabel);
      InterestArea.Controls.Add(DXTextBox);
      InterestArea.Controls.Add(DYlabel);
      InterestArea.Controls.Add(DYTextBox);
      InterestArea.Controls.Add(WidthLabel);
      InterestArea.Controls.Add(HeightLabel);
      InterestArea.Controls.Add(WidthTextBox);
      InterestArea.Controls.Add(expositionLabel);
      InterestArea.Controls.Add(HeightTextBox);
      InterestArea.Controls.Add(ExpositionTextBox);
      InterestArea.Controls.Add(focusLabel);
      InterestArea.Controls.Add(FocusTextBox);
      InterestArea.Location = new Point(140, 26);
      InterestArea.Name = "InterestArea";
      InterestArea.Size = new Size(209, 229);
      InterestArea.TabIndex = 13;
      InterestArea.TabStop = false;
      InterestArea.Text = "Область интереса";
      // 
      // DXlabel
      // 
      DXlabel.AutoSize = true;
      DXlabel.Location = new Point(118, 33);
      DXlabel.Name = "DXlabel";
      DXlabel.Size = new Size(32, 20);
      DXlabel.TabIndex = 10;
      DXlabel.Text = "DX:";
      // 
      // DXTextBox
      // 
      DXTextBox.Location = new Point(118, 56);
      DXTextBox.Name = "DXTextBox";
      DXTextBox.Size = new Size(70, 27);
      DXTextBox.TabIndex = 9;
      DXTextBox.Text = "0";
      // 
      // DYlabel
      // 
      DYlabel.AutoSize = true;
      DYlabel.Location = new Point(15, 33);
      DYlabel.Name = "DYlabel";
      DYlabel.Size = new Size(31, 20);
      DYlabel.TabIndex = 8;
      DYlabel.Text = "DY:";
      // 
      // DYTextBox
      // 
      DYTextBox.Location = new Point(15, 56);
      DYTextBox.Name = "DYTextBox";
      DYTextBox.Size = new Size(70, 27);
      DYTextBox.TabIndex = 7;
      DYTextBox.Text = "0";
      // 
      // CodeRecognition
      // 
      CodeRecognition.BackColor = SystemColors.ControlLightLight;
      CodeRecognition.BackgroundImageLayout = ImageLayout.None;
      CodeRecognition.Controls.Add(recognizeCheckBox);
      CodeRecognition.Controls.Add(checkBoxHighlight);
      CodeRecognition.Controls.Add(ButtonStopHighlightDatamatrix);
      CodeRecognition.Controls.Add(label10);
      CodeRecognition.Controls.Add(ButtonStartHighlightDatamatrix);
      CodeRecognition.Controls.Add(EndRecognizeCodeButton);
      CodeRecognition.Controls.Add(comboBox1);
      CodeRecognition.Controls.Add(RecognizeCodeButton);
      CodeRecognition.Controls.Add(CodeChoose);
      CodeRecognition.FlatStyle = FlatStyle.Popup;
      CodeRecognition.Location = new Point(12, 476);
      CodeRecognition.Name = "CodeRecognition";
      CodeRecognition.Size = new Size(372, 253);
      CodeRecognition.TabIndex = 12;
      CodeRecognition.TabStop = false;
      CodeRecognition.Text = "Распознавание кодов";
      // 
      // recognizeCheckBox
      // 
      recognizeCheckBox.AutoSize = true;
      recognizeCheckBox.BackColor = SystemColors.ButtonHighlight;
      recognizeCheckBox.Location = new Point(156, 223);
      recognizeCheckBox.Name = "recognizeCheckBox";
      recognizeCheckBox.Size = new Size(176, 24);
      recognizeCheckBox.TabIndex = 33;
      recognizeCheckBox.Text = "Начать распознание";
      recognizeCheckBox.UseVisualStyleBackColor = false;
      // 
      // checkBoxHighlight
      // 
      checkBoxHighlight.AutoSize = true;
      checkBoxHighlight.BackColor = SystemColors.ButtonHighlight;
      checkBoxHighlight.Location = new Point(156, 200);
      checkBoxHighlight.Name = "checkBoxHighlight";
      checkBoxHighlight.Size = new Size(187, 24);
      checkBoxHighlight.TabIndex = 32;
      checkBoxHighlight.Text = "Выделение DataMatrix";
      checkBoxHighlight.UseVisualStyleBackColor = false;
      // 
      // ButtonStopHighlightDatamatrix
      // 
      ButtonStopHighlightDatamatrix.BackColor = Color.Red;
      ButtonStopHighlightDatamatrix.Location = new Point(254, 127);
      ButtonStopHighlightDatamatrix.Name = "ButtonStopHighlightDatamatrix";
      ButtonStopHighlightDatamatrix.Size = new Size(93, 67);
      ButtonStopHighlightDatamatrix.TabIndex = 15;
      ButtonStopHighlightDatamatrix.Text = "Не выделять";
      ButtonStopHighlightDatamatrix.UseVisualStyleBackColor = false;
      ButtonStopHighlightDatamatrix.Click += ButtonStopHighlightDatamatrix_Click;
      // 
      // label10
      // 
      label10.AutoSize = true;
      label10.BackColor = SystemColors.ButtonHighlight;
      label10.Location = new Point(152, 101);
      label10.Name = "label10";
      label10.Size = new Size(184, 20);
      label10.TabIndex = 24;
      label10.Text = "Выделять код DataMatrix:";
      // 
      // ButtonStartHighlightDatamatrix
      // 
      ButtonStartHighlightDatamatrix.BackColor = Color.Lime;
      ButtonStartHighlightDatamatrix.Location = new Point(155, 127);
      ButtonStartHighlightDatamatrix.Name = "ButtonStartHighlightDatamatrix";
      ButtonStartHighlightDatamatrix.Size = new Size(93, 67);
      ButtonStartHighlightDatamatrix.TabIndex = 14;
      ButtonStartHighlightDatamatrix.Text = "Выделять";
      ButtonStartHighlightDatamatrix.UseVisualStyleBackColor = false;
      ButtonStartHighlightDatamatrix.Click += ButtonStartHighlightDatamatrix_Click;
      // 
      // EndRecognizeCodeButton
      // 
      EndRecognizeCodeButton.BackColor = Color.Red;
      EndRecognizeCodeButton.Location = new Point(6, 127);
      EndRecognizeCodeButton.Name = "EndRecognizeCodeButton";
      EndRecognizeCodeButton.Size = new Size(126, 97);
      EndRecognizeCodeButton.TabIndex = 15;
      EndRecognizeCodeButton.Text = "Прекратить распознавание кодов";
      EndRecognizeCodeButton.UseVisualStyleBackColor = false;
      EndRecognizeCodeButton.Click += EndRecognizeCodeButton_Click;
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Items.AddRange(new object[] { "Data_matrix(Fast)", "AUTO", "AZTEC", "CODABAR", "CODE_39", "CODE_93", "CODE_128", "Data_matrix", "EAN_8", "EAN_13", "ITF", "Резерв", "PDF_417", "QR_CODE", "резерв", "резерв", "UPC_A", "UPC_E" });
      comboBox1.Location = new Point(152, 58);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(202, 28);
      comboBox1.TabIndex = 1;
      // 
      // RecognizeCodeButton
      // 
      RecognizeCodeButton.BackColor = Color.Lime;
      RecognizeCodeButton.Location = new Point(6, 35);
      RecognizeCodeButton.Name = "RecognizeCodeButton";
      RecognizeCodeButton.Size = new Size(126, 86);
      RecognizeCodeButton.TabIndex = 14;
      RecognizeCodeButton.Text = "Начать распознавание кодов";
      RecognizeCodeButton.UseVisualStyleBackColor = false;
      RecognizeCodeButton.Click += RecognizeCodeButton_Click;
      // 
      // CodeChoose
      // 
      CodeChoose.AutoSize = true;
      CodeChoose.Location = new Point(152, 35);
      CodeChoose.Name = "CodeChoose";
      CodeChoose.Size = new Size(109, 20);
      CodeChoose.TabIndex = 0;
      CodeChoose.Text = "Выберите код:";
      // 
      // CodeData
      // 
      CodeData.AutoSize = true;
      CodeData.BackColor = SystemColors.ButtonHighlight;
      CodeData.Location = new Point(405, 476);
      CodeData.Name = "CodeData";
      CodeData.Size = new Size(116, 20);
      CodeData.TabIndex = 2;
      CodeData.Text = "Данные о коде:";
      // 
      // groupBox1
      // 
      groupBox1.BackColor = SystemColors.ButtonHighlight;
      groupBox1.Controls.Add(ButtonGradeEndShow);
      groupBox1.Controls.Add(ButtonGradeShow);
      groupBox1.Controls.Add(label9);
      groupBox1.Controls.Add(label8);
      groupBox1.Controls.Add(label7);
      groupBox1.Controls.Add(label6);
      groupBox1.Controls.Add(label5);
      groupBox1.Controls.Add(label4);
      groupBox1.Controls.Add(label3);
      groupBox1.Controls.Add(label2);
      groupBox1.Controls.Add(label1);
      groupBox1.Controls.Add(gradeShow);
      groupBox1.Controls.Add(comboBox3);
      groupBox1.Controls.Add(Label_GRD);
      groupBox1.Controls.Add(G7);
      groupBox1.Controls.Add(G6);
      groupBox1.Controls.Add(G5);
      groupBox1.Controls.Add(G4);
      groupBox1.Controls.Add(G3);
      groupBox1.Controls.Add(G2);
      groupBox1.Controls.Add(G1);
      groupBox1.Controls.Add(G0);
      groupBox1.Location = new Point(973, 55);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(358, 178);
      groupBox1.TabIndex = 23;
      groupBox1.TabStop = false;
      groupBox1.Text = "Грейд";
      // 
      // ButtonGradeEndShow
      // 
      ButtonGradeEndShow.BackColor = Color.Red;
      ButtonGradeEndShow.Location = new Point(193, 25);
      ButtonGradeEndShow.Name = "ButtonGradeEndShow";
      ButtonGradeEndShow.Size = new Size(113, 52);
      ButtonGradeEndShow.TabIndex = 31;
      ButtonGradeEndShow.Text = "Отключить грейд";
      ButtonGradeEndShow.UseVisualStyleBackColor = false;
      ButtonGradeEndShow.Click += ButtonGradeEndShow_Click;
      // 
      // ButtonGradeShow
      // 
      ButtonGradeShow.BackColor = Color.Lime;
      ButtonGradeShow.Location = new Point(59, 26);
      ButtonGradeShow.Name = "ButtonGradeShow";
      ButtonGradeShow.Size = new Size(113, 51);
      ButtonGradeShow.TabIndex = 30;
      ButtonGradeShow.Text = "Включить грейд";
      ButtonGradeShow.UseVisualStyleBackColor = false;
      ButtonGradeShow.Click += ButtonGradeShow_Click;
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
      label9.Location = new Point(17, 145);
      label9.Name = "label9";
      label9.Size = new Size(106, 20);
      label9.TabIndex = 29;
      label9.Text = "Общий грейд";
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Location = new Point(16, 541);
      label8.Name = "label8";
      label8.Size = new Size(156, 20);
      label8.TabIndex = 28;
      label8.Text = "Неисп. испр. ошибок";
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(16, 486);
      label7.Name = "label7";
      label7.Size = new Size(176, 20);
      label7.TabIndex = 27;
      label7.Text = "Запас по кф. отражения";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(17, 433);
      label6.Name = "label6";
      label6.Size = new Size(91, 20);
      label6.TabIndex = 26;
      label6.Text = "Модуляция:";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(16, 384);
      label5.Name = "label5";
      label5.Size = new Size(172, 20);
      label5.TabIndex = 25;
      label5.Text = "Неоднородность сетки:";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(17, 340);
      label4.Name = "label4";
      label4.Size = new Size(183, 20);
      label4.TabIndex = 24;
      label4.Text = "Осевая неоднородность:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(16, 291);
      label3.Name = "label3";
      label3.Size = new Size(226, 20);
      label3.TabIndex = 23;
      label3.Text = "Повреждение фикс. шаблонов:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(16, 249);
      label2.Name = "label2";
      label2.Size = new Size(139, 20);
      label2.TabIndex = 22;
      label2.Text = "Контраст символа:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(16, 206);
      label1.Name = "label1";
      label1.Size = new Size(123, 20);
      label1.TabIndex = 14;
      label1.Text = "Декодирование:";
      // 
      // gradeShow
      // 
      gradeShow.AutoSize = true;
      gradeShow.BackColor = SystemColors.ButtonHighlight;
      gradeShow.Location = new Point(17, 98);
      gradeShow.Name = "gradeShow";
      gradeShow.Size = new Size(72, 24);
      gradeShow.TabIndex = 14;
      gradeShow.Text = "Грейд";
      gradeShow.UseVisualStyleBackColor = false;
      // 
      // comboBox3
      // 
      comboBox3.FormattingEnabled = true;
      comboBox3.Items.AddRange(new object[] { "min(kn)", "mean(kn)", "0.25+0.75" });
      comboBox3.Location = new Point(219, 98);
      comboBox3.Name = "comboBox3";
      comboBox3.Size = new Size(119, 28);
      comboBox3.TabIndex = 16;
      comboBox3.Text = "mean(kn)";
      // 
      // Label_GRD
      // 
      Label_GRD.Location = new Point(257, 142);
      Label_GRD.Name = "Label_GRD";
      Label_GRD.Size = new Size(81, 27);
      Label_GRD.TabIndex = 21;
      // 
      // G7
      // 
      G7.Location = new Point(257, 534);
      G7.Name = "G7";
      G7.Size = new Size(81, 27);
      G7.TabIndex = 20;
      // 
      // G6
      // 
      G6.Location = new Point(257, 479);
      G6.Name = "G6";
      G6.Size = new Size(81, 27);
      G6.TabIndex = 19;
      // 
      // G5
      // 
      G5.Location = new Point(257, 430);
      G5.Name = "G5";
      G5.Size = new Size(81, 27);
      G5.TabIndex = 18;
      // 
      // G4
      // 
      G4.Location = new Point(257, 381);
      G4.Name = "G4";
      G4.Size = new Size(81, 27);
      G4.TabIndex = 17;
      // 
      // G3
      // 
      G3.Location = new Point(257, 337);
      G3.Name = "G3";
      G3.Size = new Size(81, 27);
      G3.TabIndex = 16;
      // 
      // G2
      // 
      G2.Location = new Point(257, 287);
      G2.Name = "G2";
      G2.Size = new Size(81, 27);
      G2.TabIndex = 15;
      // 
      // G1
      // 
      G1.Location = new Point(257, 242);
      G1.Name = "G1";
      G1.Size = new Size(81, 27);
      G1.TabIndex = 14;
      // 
      // G0
      // 
      G0.Location = new Point(257, 199);
      G0.Name = "G0";
      G0.Size = new Size(81, 27);
      G0.TabIndex = 13;
      // 
      // groupBox2
      // 
      groupBox2.BackColor = SystemColors.ControlLightLight;
      groupBox2.BackgroundImageLayout = ImageLayout.None;
      groupBox2.Controls.Add(label11);
      groupBox2.Controls.Add(trigerActivationTypeCheckBox);
      groupBox2.Controls.Add(lightModCheckBox);
      groupBox2.Controls.Add(trigerCheckBox);
      groupBox2.Controls.Add(ButtonLightModOff);
      groupBox2.Controls.Add(ButtonLightModOn);
      groupBox2.Controls.Add(ButtonTriggerOff);
      groupBox2.Controls.Add(ButtonTrigerOn);
      groupBox2.FlatStyle = FlatStyle.Popup;
      groupBox2.Location = new Point(973, 254);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(358, 343);
      groupBox2.TabIndex = 24;
      groupBox2.TabStop = false;
      groupBox2.Text = "Тригер";
      // 
      // label11
      // 
      label11.AutoSize = true;
      label11.Location = new Point(58, 54);
      label11.Name = "label11";
      label11.Size = new Size(115, 20);
      label11.TabIndex = 35;
      label11.Text = "Вид активации:";
      // 
      // trigerActivationTypeCheckBox
      // 
      trigerActivationTypeCheckBox.FormattingEnabled = true;
      trigerActivationTypeCheckBox.Items.AddRange(new object[] { "По фронту", "По спаду" });
      trigerActivationTypeCheckBox.Location = new Point(180, 47);
      trigerActivationTypeCheckBox.Name = "trigerActivationTypeCheckBox";
      trigerActivationTypeCheckBox.Size = new Size(126, 28);
      trigerActivationTypeCheckBox.TabIndex = 34;
      trigerActivationTypeCheckBox.Text = "По фронту";
      // 
      // lightModCheckBox
      // 
      lightModCheckBox.AutoSize = true;
      lightModCheckBox.BackColor = SystemColors.ButtonHighlight;
      lightModCheckBox.Location = new Point(219, 300);
      lightModCheckBox.Name = "lightModCheckBox";
      lightModCheckBox.Size = new Size(103, 24);
      lightModCheckBox.TabIndex = 33;
      lightModCheckBox.Text = "Подсветка";
      lightModCheckBox.UseVisualStyleBackColor = false;
      // 
      // trigerCheckBox
      // 
      trigerCheckBox.AutoSize = true;
      trigerCheckBox.BackColor = SystemColors.ButtonHighlight;
      trigerCheckBox.Location = new Point(29, 300);
      trigerCheckBox.Name = "trigerCheckBox";
      trigerCheckBox.Size = new Size(80, 24);
      trigerCheckBox.TabIndex = 32;
      trigerCheckBox.Text = "Тригер";
      trigerCheckBox.UseVisualStyleBackColor = false;
      // 
      // ButtonLightModOff
      // 
      ButtonLightModOff.BackColor = Color.Red;
      ButtonLightModOff.Location = new Point(212, 193);
      ButtonLightModOff.Name = "ButtonLightModOff";
      ButtonLightModOff.Size = new Size(126, 97);
      ButtonLightModOff.TabIndex = 17;
      ButtonLightModOff.Text = "Выключить подсветку";
      ButtonLightModOff.UseVisualStyleBackColor = false;
      ButtonLightModOff.Click += ButtonLightModOff_Click;
      // 
      // ButtonLightModOn
      // 
      ButtonLightModOn.BackColor = Color.Lime;
      ButtonLightModOn.Location = new Point(212, 101);
      ButtonLightModOn.Name = "ButtonLightModOn";
      ButtonLightModOn.Size = new Size(126, 86);
      ButtonLightModOn.TabIndex = 16;
      ButtonLightModOn.Text = "Включить подсветку";
      ButtonLightModOn.UseVisualStyleBackColor = false;
      ButtonLightModOn.Click += ButtonLightModOn_Click;
      // 
      // ButtonTriggerOff
      // 
      ButtonTriggerOff.BackColor = Color.Red;
      ButtonTriggerOff.Location = new Point(29, 194);
      ButtonTriggerOff.Name = "ButtonTriggerOff";
      ButtonTriggerOff.Size = new Size(126, 97);
      ButtonTriggerOff.TabIndex = 15;
      ButtonTriggerOff.Text = "Выключить тригер";
      ButtonTriggerOff.UseVisualStyleBackColor = false;
      ButtonTriggerOff.Click += ButtonTriggerOff_Click;
      // 
      // ButtonTrigerOn
      // 
      ButtonTrigerOn.BackColor = Color.Lime;
      ButtonTrigerOn.Location = new Point(29, 102);
      ButtonTrigerOn.Name = "ButtonTrigerOn";
      ButtonTrigerOn.Size = new Size(126, 86);
      ButtonTrigerOn.TabIndex = 14;
      ButtonTrigerOn.Text = "Включить тригер";
      ButtonTrigerOn.UseVisualStyleBackColor = false;
      ButtonTrigerOn.Click += ButtonTrigerOn_Click;
      // 
      // groupBox3
      // 
      groupBox3.BackColor = SystemColors.ButtonHighlight;
      groupBox3.Controls.Add(addtitonalCoordinateTextBox);
      groupBox3.Controls.Add(label15);
      groupBox3.Controls.Add(contentCodeTextBox);
      groupBox3.Controls.Add(label14);
      groupBox3.Controls.Add(mainCoordinateTextBox);
      groupBox3.Controls.Add(label13);
      groupBox3.Controls.Add(codeTypeRecognizeTextBox);
      groupBox3.Controls.Add(label12);
      groupBox3.Location = new Point(414, 511);
      groupBox3.Name = "groupBox3";
      groupBox3.Size = new Size(476, 168);
      groupBox3.TabIndex = 14;
      groupBox3.TabStop = false;
      groupBox3.Text = "Данные о распознанном коде";
      // 
      // addtitonalCoordinateTextBox
      // 
      addtitonalCoordinateTextBox.Location = new Point(149, 133);
      addtitonalCoordinateTextBox.Name = "addtitonalCoordinateTextBox";
      addtitonalCoordinateTextBox.Size = new Size(287, 27);
      addtitonalCoordinateTextBox.TabIndex = 19;
      // 
      // label15
      // 
      label15.AutoSize = true;
      label15.Location = new Point(12, 136);
      label15.Name = "label15";
      label15.Size = new Size(132, 20);
      label15.TabIndex = 20;
      label15.Text = "Доп. координаты:";
      // 
      // contentCodeTextBox
      // 
      contentCodeTextBox.Location = new Point(149, 67);
      contentCodeTextBox.Name = "contentCodeTextBox";
      contentCodeTextBox.Size = new Size(287, 27);
      contentCodeTextBox.TabIndex = 17;
      contentCodeTextBox.TextChanged += contentCodeTextBox_TextChanged;
      // 
      // label14
      // 
      label14.AutoSize = true;
      label14.Location = new Point(12, 70);
      label14.Name = "label14";
      label14.Size = new Size(100, 20);
      label14.TabIndex = 18;
      label14.Text = "Содержание:";
      // 
      // mainCoordinateTextBox
      // 
      mainCoordinateTextBox.Location = new Point(149, 100);
      mainCoordinateTextBox.Name = "mainCoordinateTextBox";
      mainCoordinateTextBox.Size = new Size(287, 27);
      mainCoordinateTextBox.TabIndex = 15;
      // 
      // label13
      // 
      label13.AutoSize = true;
      label13.Location = new Point(12, 103);
      label13.Name = "label13";
      label13.Size = new Size(131, 20);
      label13.TabIndex = 16;
      label13.Text = "Ocн. координаты:";
      // 
      // codeTypeRecognizeTextBox
      // 
      codeTypeRecognizeTextBox.Location = new Point(149, 34);
      codeTypeRecognizeTextBox.Name = "codeTypeRecognizeTextBox";
      codeTypeRecognizeTextBox.Size = new Size(287, 27);
      codeTypeRecognizeTextBox.TabIndex = 13;
      // 
      // label12
      // 
      label12.AutoSize = true;
      label12.Location = new Point(12, 37);
      label12.Name = "label12";
      label12.Size = new Size(74, 20);
      label12.TabIndex = 14;
      label12.Text = "Тип кода:";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1345, 776);
      Controls.Add(groupBox3);
      Controls.Add(groupBox2);
      Controls.Add(groupBox1);
      Controls.Add(CodeData);
      Controls.Add(CodeRecognition);
      Controls.Add(ImageWorker);
      Controls.Add(ImagePictureBox);
      Controls.Add(panel1);
      Controls.Add(PackageTextBox);
      Name = "Form1";
      Text = "Form1";
      panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)ImagePictureBox).EndInit();
      ImageWorker.ResumeLayout(false);
      FrameParam.ResumeLayout(false);
      FrameParam.PerformLayout();
      InterestArea.ResumeLayout(false);
      InterestArea.PerformLayout();
      CodeRecognition.ResumeLayout(false);
      CodeRecognition.PerformLayout();
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      groupBox3.ResumeLayout(false);
      groupBox3.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel panel1;
        private Button ConnectButton;
        private TextBox PackageTextBox;
        private PictureBox ImagePictureBox;
        private Button StartVideoButton;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private Label WidthLabel;
        private Label HeightLabel;
        private Label expositionLabel;
        private TextBox ExpositionTextBox;
        private Label focusLabel;
        private TextBox FocusTextBox;
        private GroupBox ImageWorker;
        private Button EndVideoStream;
        private GroupBox CodeRecognition;
        private Label Fps;
        private TextBox FpsTextBox;
        private GroupBox InterestArea;
        private CheckBox NetworkFrames;
        private Label DXlabel;
        private TextBox DXTextBox;
        private Label DYlabel;
        private TextBox DYTextBox;
        private Label UDPDelay;
        private TextBox UDPDelayTextBox;
        private GroupBox FrameParam;
        private Button LoadSettingsButton;
        private Button SaveSettingsButton;
        private Label CodeChoose;
        private Label CodeData;
        private ComboBox comboBox1;
        private Button EndRecognizeCodeButton;
        private Button RecognizeCodeButton;
        private Button ApplySettings;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox gradeShow;
        private ComboBox comboBox3;
        private TextBox Label_GRD;
        private TextBox G7;
        private TextBox G6;
        private TextBox G5;
        private TextBox G4;
        private TextBox G3;
        private TextBox G2;
        private TextBox G1;
        private TextBox G0;
        private Button ButtonGradeEndShow;
        private Button ButtonGradeShow;
        private Label label10;
        private CheckBox checkBoxHighlight;
        private Button ButtonStopHighlightDatamatrix;
        private Button ButtonStartHighlightDatamatrix;
        private GroupBox groupBox2;
        private Button ButtonTriggerOff;
        private Button ButtonTrigerOn;
        private Button ButtonLightModOff;
        private Button ButtonLightModOn;
        private CheckBox lightModCheckBox;
        private CheckBox trigerCheckBox;
        private ComboBox trigerActivationTypeCheckBox;
        private Label label11;
        private CheckBox recognizeCheckBox;
        private GroupBox groupBox3;
        private TextBox contentCodeTextBox;
        private Label label14;
        private TextBox mainCoordinateTextBox;
        private Label label13;
        private TextBox codeTypeRecognizeTextBox;
        private Label label12;
        private TextBox addtitonalCoordinateTextBox;
        private Label label15;
    }
}
