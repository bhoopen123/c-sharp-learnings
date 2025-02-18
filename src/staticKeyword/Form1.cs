using System;
using System.Windows.Forms;

namespace staticKeyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int aa;

        public static void gg()
        {
          // static int local;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        single instance;
        private void button1_Click(object sender, EventArgs e)
        {
          instance = single.GetInstance(); // to access the object of that class we have to call the method GetInstance
         // single ss = new single(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (instance == null)
            {

                MessageBox.Show("Instance Not created");
            }
            else
            {
                MessageBox.Show("Instance created");
            }
        }
    }

    public class single
    {
        public static single _instance;
        // single()
        //{
        //}
        private single()  // we will create a private constructor of that class so that nobody can create  the object of that 
         { }              // class directly..  
        public static single GetInstance()
        {
            if (_instance == null)
            {
                _instance = new single();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

        // this is to check whether how we can access the Public Static Data Members & Member Functions 
        // & how too access public Non-Static Data Members & Member Functions 
        //outside the class..

        StaticDemo obj = new StaticDemo();

        public void CheckClass()
        {
            StaticDemo.StaticVar = 60; //the public static Data Members & Member Functions can
            StaticDemo.StaticFun();    // be accessed only with the className outside the class.

            obj.PublicVar = 100;       // while by the object of the class we can access
            obj.NonStaticFun();         //  the public nonStatic Data Members & Member Functions.
        }
    }

    public class StaticDemo
    {
        public static int StaticVar;
        public int PublicVar;

        public static void StaticFun()
        {
            StaticVar = 50;
        }

        public void NonStaticFun()
        {
           
        }
    }

}
