using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dron_201TN_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double y = Convert.ToDouble(textBox2.Text.Replace('.', ','));

                double result = (x + y) / (y + 1) - (x * y - 12) / (34 + x);

                label3.Text = "Відповідь: " + result.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Введіть числові значення!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double rad = Convert.ToDouble(textBox3.Text.Replace('.', ','));

                double totalDegrees = rad * (180 / Math.PI);

                int d = (int)totalDegrees;
                double mFull = Math.Abs((totalDegrees - d) * 60);
                int m = (int)mFull;
                int s = (int)((mFull - m) * 60);

                label5.Text = string.Format("Результат: {0}° {1}' {2}''", d, m, s);
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть число!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(textBox4.Text.Replace('.', ','));
                double y1 = Convert.ToDouble(textBox5.Text.Replace('.', ','));
                double x2 = Convert.ToDouble(textBox6.Text.Replace('.', ','));
                double y2 = Convert.ToDouble(textBox7.Text.Replace('.', ','));
                double x3 = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                double y3 = Convert.ToDouble(textBox9.Text.Replace('.', ','));

                double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);

                label9.Text = "Площа трикутника: " + area.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Введіть усі координати як числа!");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                double s1 = Convert.ToDouble(textBox10.Text.Replace('.', ','));
                double s2 = Convert.ToDouble(textBox11.Text.Replace('.', ','));
                double s3 = Convert.ToDouble(textBox12.Text.Replace('.', ','));


                double winnerTime = Math.Min(s1, Math.Min(s2, s3));


                label14.Text = string.Format("Результат переможця запливу: {0:F2} сек.", winnerTime);
                label14.BackColor = Color.RosyBrown;
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть час спортсменів у цифрах!");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                listBox1.Items.Clear();

                int n = Convert.ToInt32(textBoxN.Text);

                if (n <= 0)
                {
                    MessageBox.Show("Введіть натуральне число (більше 0)");
                    return;
                }


                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть ціле число!");
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Очищуємо списки перед кожним розрахунком
                listBox_Source.Items.Clear();
                listBox_Result.Items.Clear();

                // 2. Створюємо масив на 15 випадкових чисел
                Random rnd = new Random();
                int[] mas = new int[15];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(1, 51); // Випадкові числа від 1 до 50
                    listBox_Source.Items.Add(mas[i]); // Виводимо початковий масив
                }

                // 3. Знаходимо мінімум (t) та максимум (M)
                int t = mas[0];
                int M = mas[0];
                foreach (int num in mas)
                {
                    if (num < t) t = num;
                    if (num > M) M = num;
                }

                // Виводимо знайдені межі в Label
                label_Info.Text = string.Format("min (t) = {0}, max (M) = {1}", t, M);
                label_Info.BackColor = Color.RosyBrown;

                // 4. Шукаємо числа з інтервалу (t; M), яких немає в масиві
                // Інтервал (t; M) не включає самі числа t та M
                for (int i = t + 1; i < M; i++)
                {
                    bool exists = false;

                    // Перевіряємо, чи є число 'i' у початковому масиві
                    foreach (int num in mas)
                    {
                        if (num == i)
                        {
                            exists = true;
                            break;
                        }
                    }

                    // Якщо числа немає в масиві — додаємо в результат
                    if (!exists)
                    {
                        listBox_Result.Items.Add(i);
                    }
                }

                // Якщо інтервал порожній
                if (listBox_Result.Items.Count == 0)
                {
                    listBox_Result.Items.Add("Чисел не знайдено");
                }
            }
            catch
            {
                MessageBox.Show("Помилка! Перевір назви: listBox_Source, listBox_Result, label_Info");
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBoxString.Text;
                int countStar = 0;   // Для *
                int countSemi = 0;   // Для ;
                int countColon = 0;  // Для :

                // Проходимо циклом по всьому рядку
                foreach (char c in s)
                {
                    if (c == '*') countStar++;
                    if (c == ';') countSemi++;
                    if (c == ':') countColon++;
                }

                // Виводимо результат у твій красивий кольоровий Label
                labelResultCount.Text = string.Format(
                    "Зірочок (*): {0}\nКрапок з комою (;): {1}\nДвокрапок (:): {2}",
                    countStar, countSemi, countColon
                );

                labelResultCount.BackColor = Color.RosyBrown; // Твій стиль
            }
            catch
            {
                MessageBox.Show("Сталася помилка!");
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }
    }
}
