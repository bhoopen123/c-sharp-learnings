using System;
using System.Windows.Forms;

namespace paramKeyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display("HI",5,6,1,5,8,7);
        }


        public void display(string ss,params int []i )
        {
            int sum=0;
             foreach(int a in i)
             {
                 sum = sum + a;
             }
             MessageBox.Show("Sum = "+sum.ToString());
        }
    }
}
