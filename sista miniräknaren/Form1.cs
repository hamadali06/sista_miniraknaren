using System;
using System.Data;
using System.Windows.Forms;

namespace miniräknare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button0.Click += new EventHandler(button_Click);
            button1.Click += new EventHandler(button_Click);
            button2.Click += new EventHandler(button_Click);
            button3.Click += new EventHandler(button_Click);
            button4.Click += new EventHandler(button_Click);
            button5.Click += new EventHandler(button_Click);
            button6.Click += new EventHandler(button_Click);
            button7.Click += new EventHandler(button_Click);
            button8.Click += new EventHandler(button_Click);
            button9.Click += new EventHandler(button_Click);
            buttonAdd.Click += new EventHandler(button_Click);
            buttonSubtract.Click += new EventHandler(button_Click);
            buttonMultiply.Click += new EventHandler(button_Click);
            buttonDivide.Click += new EventHandler(button_Click);
            buttonDot.Click += new EventHandler(button_Click);

            buttonEquals.Click += new EventHandler(buttonEquals_Click);
            buttonClear.Click += new EventHandler(buttonClear_Click);
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            textBox1.Text += button.Text;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBox1.Text, null);
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
