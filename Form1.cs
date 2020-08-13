using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class BackGround : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isoperationPerformed = false;
        public BackGround()
        {
            InitializeComponent();
        }

        private void BackGround_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Enter(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Textbox_Result.Text == "0") || (isoperationPerformed))
                Textbox_Result.Clear();
            isoperationPerformed = false;
            Button button = (Button)sender;
            if (Textbox_Result.Text == ".")
            {
                if (!Textbox_Result.Text.Contains("."))
                    Textbox_Result.Text = Textbox_Result.Text + button.Text;
            }
            else
                Textbox_Result.Text = Textbox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                Equal_Button.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isoperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(Textbox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isoperationPerformed = true;
            }
        }

        private void Clear_Button(object sender, EventArgs e)
        {
            Textbox_Result.Text = "0";
            resultValue = 0;
        }

        private void ClearE_Button(object sender, EventArgs e)
        {
            Textbox_Result.Text = "0";
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    Textbox_Result.Text = (resultValue + Double.Parse(Textbox_Result.Text)).ToString();
                    break;
                case "-":
                    Textbox_Result.Text = (resultValue - Double.Parse(Textbox_Result.Text)).ToString();
                    break;
                case "X":
                    Textbox_Result.Text = (resultValue * Double.Parse(Textbox_Result.Text)).ToString();
                    break;
                case "%":
                    Textbox_Result.Text = (resultValue / Double.Parse(Textbox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(Textbox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
