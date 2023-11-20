using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        
        private static float num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToSingle(numOneTextbox.Text);
            num2 = Convert.ToSingle(numTwoTextBox.Text);

            if (cbOperator.Text == "+")
            {
                totalLabel.Text = BasicComputation.GetSum(num1, num2).ToString();  
            } 

            else if (cbOperator.Text == "-")
            {
                totalLabel.Text = BasicComputation.GetDifference(num1, num2).ToString();
            }

            else if (cbOperator.Text == "*")
            {
                totalLabel.Text = BasicComputation.GetProduct(num1, num2).ToString();
            }

            else if (cbOperator.Text == "/")
            {
                totalLabel.Text = BasicComputation.GetQoutient(num1, num2).ToString();
            }
        }
    }
}
