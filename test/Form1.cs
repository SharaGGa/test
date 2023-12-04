namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int a = 0;
        public int currentQuestion = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (currentQuestion)
            {
                case 1:
                    if (radioButton1.Checked)
                    {
                        a++;
                    }
                    label1.Text = "2. Какой метод используется для определения длины массива в C#?";
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton10.Visible = true;
                    radioButton11.Visible = true;
                    radioButton12.Visible = true;
                    currentQuestion++;
                    break;
                case 2:
                    if (radioButton12.Checked)
                    {
                        a++;
                    }
                    label1.Text = "3. Какой синтаксис для создания метода, который принимает два целых числа и возвращает их сумму?";
                    radioButton10.Visible = false;
                    radioButton11.Visible = false;
                    radioButton12.Visible = false;
                    radioButton13.Visible = true;
                    radioButton14.Visible = true;
                    radioButton15.Visible = true;
                    currentQuestion++;
                    break;
                case 3:
                    if (radioButton13.Checked)
                    {
                        a++;
                    }
                    label1.Text = "4. Какой оператор используется для сравнения двух значений в C#?";
                    radioButton13.Visible = false;
                    radioButton14.Visible = false;
                    radioButton15.Visible = false;
                    radioButton16.Visible = true;
                    radioButton17.Visible = true;
                    radioButton18.Visible = true;
                    currentQuestion++;
                    break;
                case 4:
                    if (radioButton18.Checked)
                    {
                        a++;
                    }
                    label1.Text = "5. Какой синтаксис для создания цикла for, который выполняется 10 раз?";
                    radioButton16.Visible = false;
                    radioButton17.Visible = false;
                    radioButton18.Visible = false;
                    radioButton19.Visible = true;
                    radioButton20.Visible = true;
                    radioButton21.Visible = true;
                    currentQuestion++;
                    break;
                case 5:
                    if (radioButton20.Checked)
                    {
                        a++;
                    }
                    label1.Text = "6. Какой синтаксис для создания цикла while, который выполняется, пока переменная меньше 10?";
                    radioButton19.Visible = false;
                    radioButton20.Visible = false;
                    radioButton21.Visible = false;
                    radioButton22.Visible = true;
                    radioButton23.Visible = true;
                    radioButton24.Visible = true;
                    currentQuestion++;
                    break;
                case 6:
                    if (radioButton24.Checked)
                    {
                        a++;
                    }
                    label1.Text = "7. Какой синтаксис для создания условного оператора if, который проверяет, является ли переменная положительной?";
                    radioButton22.Visible = false;
                    radioButton23.Visible = false;
                    radioButton24.Visible = false;
                    radioButton25.Visible = true;
                    radioButton26.Visible = true;
                    radioButton27.Visible = true;
                    currentQuestion++;
                    break;
                case 7:
                    if (radioButton25.Checked)
                    {
                        a++;
                    }
                    label1.Text = "8. Какой синтаксис для создания switch-case конструкции в C#?";
                    radioButton25.Visible = false;
                    radioButton26.Visible = false;
                    radioButton27.Visible = false;
                    radioButton28.Visible = true;
                    radioButton29.Visible = true;
                    radioButton30.Visible = true;
                    currentQuestion++;
                    break;
                case 8:
                    if (radioButton30.Checked)
                    {
                        a++;
                    }
                    label1.Text = "9. Как вызвать метод в C#?";
                    radioButton28.Visible = false;
                    radioButton29.Visible = false;
                    radioButton30.Visible = false;
                    radioButton31.Visible = true;
                    radioButton32.Visible = true;
                    radioButton33.Visible = true;
                    currentQuestion++;
                    break;
                case 9:
                    if (radioButton31.Checked)
                    {
                        a++;
                    }
                    label1.Text = "10. Как передать массив в качестве аргумента методу в C#?";
                    radioButton31.Visible = false;
                    radioButton32.Visible = false;
                    radioButton33.Visible = false;
                    radioButton34.Visible = true;
                    radioButton35.Visible = true;
                    radioButton36.Visible = true;
                    currentQuestion++;
                    break;
                case 10:
                    if (radioButton36.Checked)
                    {
                        a++;
                    }
                    label1.Text = $"Верных ответов: {a}.";
                    radioButton34.Visible = false;
                    radioButton35.Visible = false;
                    radioButton36.Visible = false;
                    button1.Visible = false;
                    button2.Visible = true;
                    label5.Visible = true;
                    if (a == 10)
                        label5.Text = "Оценка: 5.";
                    else if (a == 9 | a == 8 | a == 7)
                        label5.Text = "Оценка: 4.";
                    else if (a == 6 | a == 5)
                        label5.Text = "Оценка: 3.";
                    else
                        label5.Text = "Оценка : 2.";
                    break;








            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
