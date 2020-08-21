using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calc
{
    public partial class BackGround : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isoperationPerformed = false;
        public int hour = 0;
        public int min = 0;
        public int sec = 0;
        bool timeSet = false; //작동 여부
        bool pause = false; //정지 상태 여부


        //백그라운드 이벤트리스너
        public BackGround()
        {
            InitializeComponent();

            btn_start.Click += btn_start_click;
            btn_stop.Click += btn_stop_click;
            btn_reset.Click += btn_reset_click;
        }

        //스탑워치 초당 간격 설정
        public void stopWatch_tick(object sender, EventArgs e)
        {
            ShowTime();
            incSec();
        }

        //시작 버튼을 누를 시
        private void btn_start_click(object sender, EventArgs e)
        {
            if (!timeSet)
            {
                timer1.Enabled = true;
                timer1.Interval = 1000;
                timer1.Tick += stopWatch_tick;
                timeSet = true;
            }
            else if (pause)
            {
                timer1.Enabled = true;
                pause = false;
            }
        }

        //정지 버튼을 누를 시
        private void btn_stop_click(object sender, EventArgs e)
        {
            if (timeSet)
            {
                timer1.Enabled = false;
                pause = true;
            }
        }

        //초기화 버튼을 누를 시
        private void btn_reset_click(object sender, EventArgs e)
        {
            hour = 0;
            min = 0;
            sec = 0;

            ShowTime();
            if (timeSet)
            {
                timeSet = false;
                pause = false;
            }
        }

        //스탑워치 화면 초기화
        private void ShowTime()
        {
            label1.Text = hour.ToString("00");
            label2.Text = min.ToString("00");
            label3.Text = sec.ToString("00");
        }

        //시간 증가
        private void incHour()
        {
            hour++;
        }

        //분 증가
        private void incMin()
        {
            if (min > 59)
            {
                min = 0;
                incHour();
            }
            else
            {
                min++;
            }
        }

        //초 증가
        private void incSec()
        {
            if (sec > 59)
            {
                sec = 0;
                incMin();
            }
            else
            {
                sec++;
            }
        }
        //

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

        private void btn_Click(object sender, EventArgs e)
        {
            if ((Textbox_Result.Text == "0") || (isoperationPerformed))
                Textbox_Result.Clear();
            isoperationPerformed = false;
            Button button = (Button)sender;
            if (Textbox_Result.Text == ".")
            {
                if(!(button.Text == "."))
                {
                    Textbox_Result.Text = Textbox_Result.Text + button.Text;
                } 
            }
            else
                Textbox_Result.Text = Textbox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((resultValue != 0))
            {
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
            labelCurrentOperation.Text = "";
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
                case "/":
                    Textbox_Result.Text = (resultValue / Double.Parse(Textbox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(Textbox_Result.Text);
            labelCurrentOperation.Text = "";
            isoperationPerformed = false;
        }

        private void Timer_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}


