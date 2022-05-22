using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avia
{
    public partial class Add_element : Form
    {
        Form1 form;
        public Add_element(Form1 form1)
        {
            InitializeComponent();
            form = form1;
            form.classes = new classes() { name = "null" };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") ||
            (textBox1.Text == "") ||
            (textBox3.Text == "") ||
            (textBox5.Text == "") ||
            (textBox6.Text == "") ||
            (textBox7.Text == ""))
            {
                MessageBox.Show("Пустое поле!");
            }
            classes classes = new classes()
            {
                name = textBox2.Text,
                firstName = textBox1.Text,
                path = textBox3.Text,
                birt = dateTimePicker1.Value,
                pass = textBox5.Text,
                address = textBox6.Text,
                telephone = textBox7.Text,
            };
            form.classes = classes;

            this.Dispose();
        }
    }
}
