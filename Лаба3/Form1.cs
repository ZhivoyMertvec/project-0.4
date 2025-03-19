using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = ("Безопасность");
            for (int j = 0; j < 4; j++)
            {
                dataGridView1.Rows[j].HeaderCell.Value = Convert.ToString(j + 1);
            }
            dataGridView2.RowCount = 4;
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].HeaderText = ("Ур. Доступа");
            for (int j = 0; j < 4; j++)
            {
                dataGridView2.Rows[j].HeaderCell.Value = Convert.ToString(j + 1);
            }
            dataGridView1.Rows[0].Cells[0].Value = 10;
            dataGridView1.Rows[1].Cells[0].Value = 20;
            dataGridView1.Rows[2].Cells[0].Value = 50;
            dataGridView1.Rows[3].Cells[0].Value = 100;
            dataGridView2.Rows[0].Cells[0].Value = 10;
            dataGridView2.Rows[1].Cells[0].Value = 20;
            dataGridView2.Rows[2].Cells[0].Value = 50;
            dataGridView2.Rows[3].Cells[0].Value = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool osh = false;
            try
            {
                int f = Convert.ToInt32(textBox1.Text);
                int c = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Неверное значение");
                osh = true;
            }
            if (osh == false)
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                if (a >= 1 && a <= 4 && b >= 1 && b <= 4) 
                {
                    int obj = Convert.ToInt32(dataGridView1.Rows[b - 1].Cells[0].Value);
                    int pol = Convert.ToInt32(dataGridView2.Rows[a - 1].Cells[0].Value);
                    if (pol >= obj)
                    {
                        MessageBox.Show("Пользователь " + textBox1.Text + " имеет доступ к объекту " + textBox2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Пользователь " + textBox1.Text + " не имеет доступ к объекту " + textBox2.Text);
                    }
                }
                else 
                {
                    MessageBox.Show("Неверное значение");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool osh = false;
            try
            {
                int f = Convert.ToInt32(textBox3.Text);
                int c = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Неверное значение");
                osh = true;
            }
            if (osh == false)
            {
                int pol = Convert.ToInt32(textBox3.Text);
                int ur = Convert.ToInt32(textBox4.Text);
                if (pol >= 1 && pol <= 4)
                {
                    dataGridView2.Rows[pol - 1].Cells[0].Value = ur;
                }
                else
                {
                    MessageBox.Show("Неверное значение");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool osh = false;
            try
            {
                int f = Convert.ToInt32(textBox5.Text);
                int c = Convert.ToInt32(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Неверное значение");
                osh = true;
            }
            if (osh == false)
            {
                int obj = Convert.ToInt32(textBox5.Text);
                int ur = Convert.ToInt32(textBox6.Text);
                if (obj >= 1 && obj <= 4)
                {
                    dataGridView1.Rows[obj - 1].Cells[0].Value = ur;
                }
                else
                {
                    MessageBox.Show("Неверное значение");
                }
            }
        }
    }
}
