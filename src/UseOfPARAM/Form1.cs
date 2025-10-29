using System;
using System.Windows.Forms;

namespace UseOfPARAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int[] arr = {25,12,45,13};      // this is the way by which we can pass the array to the method 
            //ParamFun(arr);                  // but we want to pass these values to the method parametres directly 
            // that can be done by using the PARAMS keyword in the Function

            // using PARAMS keyword
            ParamFun("zdffda", 36, 25, 01, 45, 58);       // as many parametres as we can pass while callling the Function
                                                          // but all the parametre type must be same..


            // to call the funtion with out parameter 
            int Sum, Diff, Mult;
            OutParaFun(25, 5, out Sum, out Diff, out Mult);
            MessageBox.Show("Sum = " + Sum.ToString() + " Difference = " + Diff.ToString() + " Multiply = " + Mult.ToString());
        }


        public void OutParaFun(int num1, int num2, out int sum, out int diff, out int mult)
        {
            sum = num1 + num2;
            diff = num1 - num2;
            mult = num1 * num2;
        }

        public void ParamFun(string Strfirst, int first, params int[] arr)     // we use PARAMS // ifwe want to access a specific parameter value then 
        {                                                           // put the parameter before Param keyword 
            int sum = 0;
            foreach (int ar in arr)
            {
                sum = sum + ar;
            }
            MessageBox.Show("Sum of the Numbers = " + sum.ToString() + " And the first value is " + first.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }



}
