namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 + num2;
            label1.Text = "Результат: " + result.ToString();


        }
        private void button2_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int min = num1 - num2;
            label1.Text = "Результат: " + min.ToString();


        }
        private void button3_Click(object sender, EventArgs e)
        {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                label1.Text = "Результат: " + result.ToString();
            
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            if (num2 == 0)
            {
                MessageBox.Show("На ноль делить нельзя!", "Ошибка");
            }
            else
            {
                double divisionResult = (double)num1 / num2; 
                label1.Text = "Результат: " + divisionResult.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = double.Parse(textBox1.Text);
                if (num1 < 0)
                {
                    MessageBox.Show("Невозможно извлечь корень из отрицательного числа!", "Ошибка");
                }
                else
                {
                    double result = Math.Sqrt(num1);
                    label1.Text = "Результат: " + result.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода! Пожалуйста, введите число.", "Ошибка");
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    int num2 = int.Parse(textBox2.Text);
                    label1.Text = "Результат: " + (num2 * num2).ToString();
                }
                else if (!string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
                {
                    int num1 = int.Parse(textBox1.Text);
                    label1.Text = "Результат: " + (num1 * num1).ToString();
                }
                else
                {
                    label1.Text = "Ошибка: Укажите только одно число.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода! Пожалуйста, введите число.", "Ошибка");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
    
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Введите число в первое поле!", "Ошибка");
                    return;
                }
                double number = double.Parse(textBox1.Text);
                if (number < 0)
                {
                    MessageBox.Show("Квадратный корень не может быть извлечён из отрицательного числа!", "Ошибка");
                }
                else
                {
                    double result = Math.Sqrt(number);
                    label1.Text = "Результат: " + result.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода! Убедитесь, что введено корректное число.", "Ошибка");
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int min = num1 / num2;
            label1.Text = "Результат: " + min.ToString();


        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "Результат:";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text = "";
            }
            else if (textBox2.Focused)
            {
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Выберите текстовое поле для очистки.", "Ошибка");
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text); 
                if (num == 0)
                {
                    MessageBox.Show("Невозможно вычислить обратное значение для нуля!", "Ошибка");
                }
                else
                {
                    double result = 1 / num;
                    label1.Text = "Результат: " + result.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода! Убедитесь, что введено корректное число.", "Ошибка");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused && textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else if (textBox2.Focused && textBox2.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("Выберите текстовое поле и убедитесь, что в нём есть текст.", "Ошибка");
            }
        }
        private void InsertDigit(string digit)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += digit;
            }
            else if (textBox2.Focused)
            {
                textBox2.Text += digit;
            }
            else
            {
                MessageBox.Show("Выберите текстовое поле для ввода.", "Ошибка");
            }
        }

  
        private void button13_Click(object sender, EventArgs e)
        {
            InsertDigit("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InsertDigit("2");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            InsertDigit("3");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            InsertDigit("4");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            InsertDigit("5");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            InsertDigit("6");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            InsertDigit("7");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            InsertDigit("8");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InsertDigit("9");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Focused)
                {
                    double num = double.Parse(textBox1.Text);
                    textBox1.Text = (-num).ToString();
                }
                else if (textBox2.Focused)
                {
                    double num = double.Parse(textBox2.Text);
                    textBox2.Text = (-num).ToString();
                }
                else
                {
                    MessageBox.Show("Выберите текстовое поле.", "Ошибка");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода! Убедитесь, что введено корректное число.", "Ошибка");
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused && !textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            else if (textBox2.Focused && !textBox2.Text.Contains(","))
            {
                textBox2.Text += ",";
            }
            else
            {
                MessageBox.Show("Выберите текстовое поле для ввода.", "Ошибка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
