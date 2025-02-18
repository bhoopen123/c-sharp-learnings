using System;
using System.Windows.Forms;

namespace objectInCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object oo="bbb";
            if (oo.ToString() == "bbb") // this expression is not valid as 'oo' is a object type and we have to typecaste it to string 
            {
                MessageBox.Show(oo.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
