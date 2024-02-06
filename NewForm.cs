using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrafSinLine
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            try
            {
                form1.firstNumber = double.Parse(textBox1.Text);
                form1.secondNumber = double.Parse(textBox2.Text);

                form1.DataFirstNumber = textBox1.Text;
                form1.DataSecondNumber = textBox2.Text;

            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n " +
                    er.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            this.Close();
            form1.Refresh();

        }
    }
}
