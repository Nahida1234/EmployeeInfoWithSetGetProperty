using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoWithSetGetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee anEmployee=new Employee();
        private void button1_Click(object sender, EventArgs e)
        {
            anEmployee._id = idTextBox.Text;
            anEmployee._name = nameTextBox.Text;
            anEmployee._salary = Convert.ToDouble(salaryTextBox.Text);

            MessageBox.Show(@"Info saved successfully");

            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idTextBox.Text = anEmployee._id;
            nameTextBox.Text = anEmployee._name;
            salaryTextBox.Text = anEmployee._salary.ToString();

            MessageBox.Show(@"Retrive successfully");
        }
    }
}
