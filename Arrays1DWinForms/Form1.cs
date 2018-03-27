using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1DWinForms
{
    public partial class Form1 : Form
    {double[] arr = new double[100];
      Random rnd = new Random();
        

        public Form1()
        {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            InitializeComponent();
                
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numericUpDown1.Text);
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = n;

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-156, 543) / 10.0;
                dataGridViewArray[i,0].Value = arr[i];
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
            }

        }

        private void findmark_Click(object sender, EventArgs e)
        {   int n = int.Parse(numericUpDown1.Text);
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.ColumnCount = n;
           
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                
                    double array = arr[i];
                    if ((array * 10) % 10 >= 5) { sum += Math.Abs(arr[i]); }
               
            }
            Text_s.Text = sum.ToString("F1");
            double a;
            int imin;
            for (int i = n/2; i < n - 1; i++)
            {
                imin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[imin])
                    {
                        imin = j;
                        a = arr[i];
                        arr[i] = arr[imin];
                        arr[imin] = a;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
               
                dataGridViewArray[i, 0].Value = arr[i];
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
            }
        }
            
            
    }
}
