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
    public partial class Form1 : Form
    {
        public double firstNumber, secondNumber;


        public string DataFirstNumber
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }

        }
        public string DataSecondNumber
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double resultFunction = 0;
            Point point1, point2;
            int widht = (int)panel1.Width;
            int heigth = (int)panel1.Height;
            int y = heigth / 2;

            for (int x = 0; x < widht; x++)
            {
                point1 = new Point(x, y);
                resultFunction = Operation.SummSin(x, firstNumber, secondNumber);

                y = (int)(resultFunction * heigth / 5);
                y = y + heigth / 2;

                point2 = new Point(x, y);

                Graphics dc = e.Graphics;
                Pen pen = new Pen(Color.Red, 1);

                dc.DrawLine(pen, point1, point2);


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = double.Parse(DataFirstNumber);
                secondNumber = double.Parse(DataSecondNumber);
                panel1.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n " +
                    er.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit editF = new edit();
            editF.Show(this);

        }

        public Form1()
        {
            InitializeComponent();
            firstNumber = 0.1;
            secondNumber = 0.04;
        }
    }
}
