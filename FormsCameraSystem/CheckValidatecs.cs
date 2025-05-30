using System;
using System.Windows.Forms;

namespace FormsCameraSystem
{
    internal class CheckValidatecs
    {
        private TextBox widthTextBox;
        private TextBox heightTextBox;
        private TextBox expositionTextBox;
        private TextBox focusTextBox;

        public CheckValidatecs(TextBox widthTextBox, TextBox heightTextBox, TextBox expositionTextBox, TextBox focusTextBox)
        {
            this.widthTextBox = widthTextBox;
            this.heightTextBox = heightTextBox;
            this.expositionTextBox = expositionTextBox;
            this.focusTextBox = focusTextBox;

            // Подключаем обработчики событий
            this.widthTextBox.TextChanged += WidthTextBox_TextChanged;
            this.heightTextBox.TextChanged += HeightTextBox_TextChanged;
            this.expositionTextBox.TextChanged += ExpositionTextBox_TextChanged;
            this.focusTextBox.TextChanged += FocusTextBox_TextChanged;

            // Ограничиваем ввод только числами
            this.widthTextBox.KeyPress += NumericTextBox_KeyPress;
            this.heightTextBox.KeyPress += NumericTextBox_KeyPress;
            this.expositionTextBox.KeyPress += NumericTextBox_KeyPress;
            this.focusTextBox.KeyPress += NumericTextBox_KeyPress;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(widthTextBox.Text, out int value))
            {
                if (value < 1 || value > 1200)
                {
                    MessageBox.Show("Width must be between 1 and 1200.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //widthTextBox.Text = "1000"; // Значение по умолчанию
                }
            }
            else
            {
                widthTextBox.Text = "1000"; // Значение по умолчанию
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(heightTextBox.Text, out int value))
            {
                if (value < 1 || value > 1200)
                {
                    MessageBox.Show("Height must be between 1 and 1200.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //heightTextBox.Text = "1000"; // Значение по умолчанию
                }
            }
            else
            {
                heightTextBox.Text = "1000"; // Значение по умолчанию
            }
        }

        private void ExpositionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(expositionTextBox.Text, out int value))
            {
                if (value < 1 || value > 10000)
                {
                    MessageBox.Show("Exposition must be between 1 and 10000.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //expositionTextBox.Text = "3000"; // Значение по умолчанию
                }
            }
            else
            {
                expositionTextBox.Text = "3000"; // Значение по умолчанию
            }
        }

        private void FocusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(focusTextBox.Text, out int value))
            {
                if (value < 1 || value > 100)
                {
                    MessageBox.Show("Focus must be between 1 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //focusTextBox.Text = "20"; // Значение по умолчанию
                }
            }
            else
            {
                focusTextBox.Text = "20"; // Значение по умолчанию
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отклонить ввод
            }
        }
    }
}
