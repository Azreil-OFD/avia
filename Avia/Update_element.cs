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
    public partial class Update_element : Form
    {
        Form1 form;
        classes classesCl = new classes();
        public Update_element( Form1 form1 , classes cla )
        {
            InitializeComponent();


            form = form1;

            textBox2.Text = cla.name;
            textBox1.Text = cla.firstName;
            textBox3.Text = cla.path;
            dateTimePicker1.Value = cla.birt;
            textBox5.Text = cla.pass;
            textBox6.Text = cla.address;
            textBox7.Text = cla.telephone;


            classesCl = cla;
            form.classes = new classes() { name = "null"};

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
                return;
            }
            else
            {
                classes classes = new classes()
                {
                    name = textBox2.Text,
                    firstName = textBox1.Text,
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
}
