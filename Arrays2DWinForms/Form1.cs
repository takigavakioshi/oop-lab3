using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2DWinForms
{
    public partial class Form1 : Form
    {
        double[,] arr = new double[100, 100];
        Random rnd = new Random();
        double[] ar = new double[100];
        public Form1()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
           System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(nn.Text);
            int m = int.Parse(mm.Text);
            dataGridViewArray.RowCount = m;
            dataGridViewArray.ColumnCount = n;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToDouble(rnd.Next(-28305, 12951) / 1000.000);
                    dataGridViewArray[j, i].Value = arr[i, j];
                    dataGridViewArray.Columns[j].HeaderText = j.ToString();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(nn.Text);
            int m = int.Parse(mm.Text);
            dataGridViewArray.RowCount = m;
            dataGridViewArray.ColumnCount = n;

            double min = 10000, max = -10000;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    if (min > arr[i, j]) { min = arr[i, j]; }
                }
                ar[i] = min;
                min = 10000;
            }

            for (int i = 0; i < m; i++)
            {
                if (max < ar[i]) { max = ar[i]; }
            }

            Text_s.Text = max.ToString();


            double temp;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp = arr[i, j];
                    if (arr[i, j] < 0)
                    {

                        temp = arr[i, n - 1];
                        for (int k = n - 1; k > 0; k--)
                            arr[i, k] = arr[i, k - 1];
                        arr[i, 1] = temp;

                    }

                }

            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridViewArray[j, i].Value = arr[i, j];
                    dataGridViewArray.Columns[j].HeaderText = j.ToString();
                }
            }
        }
    }
}
