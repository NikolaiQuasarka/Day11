namespace Day11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FuncMas<double> mas;
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_countmas.Text, out int count))
            {
                mas = new FuncMas<double>(count);
                Random rnd = new Random();
                for (int i = 0; i < count; i++)
                {
                    mas.mas[i] = rnd.Next(-10, 10);
                }
                Update();
            }
        }

        private void Update()
        {
            listView1.Items.Clear();
            foreach (double item in mas.mas)
            {
                listView1.Items.Add(item.ToString());
            }
            textBox_count.Text = mas.NumbersLower.ToString();
            textBox_sum.Text = mas.Sum().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_countmas.Text, out int count)&double.TryParse(textBox_x.Text,out double x))
            {
                mas = new FuncMas<double>(count, x);
                Update();
            }
        }
    }
}
