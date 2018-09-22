using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForJenkinsIntegrate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверяем сборку в Jenkins");

            Calc calc = new Calc();
            calc.Summ(5, 3);
        }
        
    }

    public class Calc
    {
        public int Summ(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
