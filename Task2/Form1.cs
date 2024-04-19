using Microsoft.VisualBasic;
using System.Collections;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sorterdSet = new SortedSet<float>();
            queue = new Queue<float>();
        }
        SortedSet<float> sorterdSet;
        Queue<float> queue;

        private void Update1()
        {
            listView1.Items.Clear();
            foreach (float item in sorterdSet)
            {
                listView1.Items.Add(item.ToString());
            }
        }
        private void Update2()
        {
            listView2.Items.Clear();
            foreach (float item in queue)
            {
                listView2.Items.Add(item.ToString());
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float value))
            {
                sorterdSet.Add(value);
                textBox1.Text = "";
                Update1();
            }

        }

        private void button_AddTo_Click(object sender, EventArgs e)
        {
            foreach (float item in sorterdSet)
            {
                queue.Enqueue(item);
            }
            Update2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(float.TryParse(textBox_since.Text, out float since)&float.TryParse(textBox_after.Text,out float after))
            {
                sorterdSet.RemoveWhere(x=>since<x&x<after);
                Update1();
            }
        }
    }
}
