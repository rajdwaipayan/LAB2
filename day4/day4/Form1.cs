using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day4
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string> { "Dwaipayan" };

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            
            names.Add(nameTextBox1.Text);
            ShowCustomer();
            

            //for(int i=0;i<name.Count();i++)
            //{
            //    message += "Name is : " + name[i] + "\n\n";
            //}
       
           
        }
        private void ShowCustomer()
        {
            string message = " ";
            foreach (string name in names)
            {
                message += "Name is : " + name + "\n\n";
            }
            MessageBox.Show(message);
        }

        private void showButton1_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }
    }
}
