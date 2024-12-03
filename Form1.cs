using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateCalculator { 

    delegate double CalcuOperation(double num1, double num2);
    public partial class CalculatorApp : Form
    {
        public CalculatorApp()
        {
            InitializeComponent();
        }

    private void btn_Calculate_Click(object sender, EventArgs e)
    {
        string dropboxOperation = drop_Operations.Text;
        double firstNum = Convert.ToDouble(txtBox_FirstNum.Text);
        double secondNum = Convert.ToDouble(txtBox_SecondNum.Text);
        CalcuOperation operation;

        if (dropboxOperation == "+")
            operation = Add;
        else if (dropboxOperation == "-")
            operation = Subtract;
        else if (dropboxOperation == "*")
            operation = Multiply;
        else if (dropboxOperation == "/")
            operation = Divide;
        else
            throw new InvalidOperationException("Ivalid choice");
        
        double result = operation(firstNum, secondNum);
        lb_TotalAns.Text = Convert.ToString(result);
    }

    double Add(double num1, double num2) {return num1 + num2; }
    double Subtract(double num1, double num2) { return num1 - num2; }
    double Multiply(double num1, double num2) { return num1 * num2; }
    double Divide(double num1, double num2) { return num1 / num2; }

}
}
