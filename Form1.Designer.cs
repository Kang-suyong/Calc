﻿namespace Calc
{
    partial class BackGround
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculator = new System.Windows.Forms.GroupBox();
            this.ByProduction = new System.Windows.Forms.Label();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.Textbox_Result = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.GroupBox();
            this.Byproduction2 = new System.Windows.Forms.Label();
            this.Ptimer = new System.Windows.Forms.Panel();
            this.Pclac = new System.Windows.Forms.Panel();
            this.Equal_Button = new System.Windows.Forms.Button();
            this.Calculator.SuspendLayout();
            this.Timer.SuspendLayout();
            this.Pclac.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Calculator.Controls.Add(this.Equal_Button);
            this.Calculator.Controls.Add(this.ByProduction);
            this.Calculator.Controls.Add(this.labelCurrentOperation);
            this.Calculator.Controls.Add(this.Textbox_Result);
            this.Calculator.Controls.Add(this.button18);
            this.Calculator.Controls.Add(this.button17);
            this.Calculator.Controls.Add(this.button16);
            this.Calculator.Controls.Add(this.button15);
            this.Calculator.Controls.Add(this.button14);
            this.Calculator.Controls.Add(this.button13);
            this.Calculator.Controls.Add(this.button12);
            this.Calculator.Controls.Add(this.button11);
            this.Calculator.Controls.Add(this.button10);
            this.Calculator.Controls.Add(this.button8);
            this.Calculator.Controls.Add(this.button7);
            this.Calculator.Controls.Add(this.button6);
            this.Calculator.Controls.Add(this.button5);
            this.Calculator.Controls.Add(this.button4);
            this.Calculator.Controls.Add(this.button3);
            this.Calculator.Controls.Add(this.button2);
            this.Calculator.Controls.Add(this.button1);
            this.Calculator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Calculator.Font = new System.Drawing.Font("나눔손글씨 펜", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Calculator.ForeColor = System.Drawing.Color.White;
            this.Calculator.Location = new System.Drawing.Point(0, 0);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(500, 600);
            this.Calculator.TabIndex = 0;
            this.Calculator.TabStop = false;
            this.Calculator.Text = "Caculator";
            this.Calculator.Enter += new System.EventHandler(this.Calculator_Enter);
            // 
            // ByProduction
            // 
            this.ByProduction.AutoSize = true;
            this.ByProduction.Font = new System.Drawing.Font("휴먼아미체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ByProduction.ForeColor = System.Drawing.Color.White;
            this.ByProduction.Location = new System.Drawing.Point(399, 577);
            this.ByProduction.Name = "ByProduction";
            this.ByProduction.Size = new System.Drawing.Size(101, 20);
            this.ByProduction.TabIndex = 5;
            this.ByProduction.Text = "made by 동준";
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCurrentOperation.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCurrentOperation.ForeColor = System.Drawing.Color.White;
            this.labelCurrentOperation.Location = new System.Drawing.Point(85, 144);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 21);
            this.labelCurrentOperation.TabIndex = 19;
            this.labelCurrentOperation.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Textbox_Result
            // 
            this.Textbox_Result.Font = new System.Drawing.Font("함초롬돋움", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Textbox_Result.Location = new System.Drawing.Point(89, 173);
            this.Textbox_Result.Multiline = true;
            this.Textbox_Result.Name = "Textbox_Result";
            this.Textbox_Result.Size = new System.Drawing.Size(324, 47);
            this.Textbox_Result.TabIndex = 18;
            this.Textbox_Result.Text = "0";
            this.Textbox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Textbox_Result.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button18.ForeColor = System.Drawing.Color.Maroon;
            this.button18.Location = new System.Drawing.Point(353, 226);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 60);
            this.button18.TabIndex = 17;
            this.button18.Text = "CE";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ClearE_Button);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button17.ForeColor = System.Drawing.Color.DarkRed;
            this.button17.Location = new System.Drawing.Point(353, 292);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 60);
            this.button17.TabIndex = 16;
            this.button17.Text = "C";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Clear_Button);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(89, 424);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(126, 60);
            this.button16.TabIndex = 15;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(221, 424);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 60);
            this.button15.TabIndex = 14;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.ForeColor = System.Drawing.Color.DimGray;
            this.button14.Location = new System.Drawing.Point(287, 358);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 60);
            this.button14.TabIndex = 13;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.operator_click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.ForeColor = System.Drawing.Color.DimGray;
            this.button13.Location = new System.Drawing.Point(287, 226);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 60);
            this.button13.TabIndex = 12;
            this.button13.Text = "%";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.ForeColor = System.Drawing.Color.DimGray;
            this.button12.Location = new System.Drawing.Point(287, 424);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 11;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.operator_click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.ForeColor = System.Drawing.Color.DimGray;
            this.button11.Location = new System.Drawing.Point(287, 292);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 60);
            this.button11.TabIndex = 10;
            this.button11.Text = "X";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(221, 358);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 60);
            this.button10.TabIndex = 9;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(221, 226);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(89, 292);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(155, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(221, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(89, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(155, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(155, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(89, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // Timer
            // 
            this.Timer.Controls.Add(this.Byproduction2);
            this.Timer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Timer.ForeColor = System.Drawing.Color.Black;
            this.Timer.Location = new System.Drawing.Point(661, 36);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(500, 600);
            this.Timer.TabIndex = 1;
            this.Timer.TabStop = false;
            this.Timer.Text = "타이머";
            // 
            // Byproduction2
            // 
            this.Byproduction2.AutoSize = true;
            this.Byproduction2.ForeColor = System.Drawing.Color.Black;
            this.Byproduction2.Location = new System.Drawing.Point(367, 578);
            this.Byproduction2.Name = "Byproduction2";
            this.Byproduction2.Size = new System.Drawing.Size(127, 19);
            this.Byproduction2.TabIndex = 6;
            this.Byproduction2.Text = "made by 수용";
            // 
            // Ptimer
            // 
            this.Ptimer.Location = new System.Drawing.Point(661, 36);
            this.Ptimer.Name = "Ptimer";
            this.Ptimer.Size = new System.Drawing.Size(503, 594);
            this.Ptimer.TabIndex = 2;
            // 
            // Pclac
            // 
            this.Pclac.Controls.Add(this.Calculator);
            this.Pclac.Location = new System.Drawing.Point(15, 30);
            this.Pclac.Name = "Pclac";
            this.Pclac.Size = new System.Drawing.Size(500, 600);
            this.Pclac.TabIndex = 3;
            // 
            // Equal_Button
            // 
            this.Equal_Button.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Equal_Button.ForeColor = System.Drawing.Color.Brown;
            this.Equal_Button.Location = new System.Drawing.Point(353, 358);
            this.Equal_Button.Name = "Equal_Button";
            this.Equal_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Equal_Button.Size = new System.Drawing.Size(60, 126);
            this.Equal_Button.TabIndex = 20;
            this.Equal_Button.Text = "=";
            this.Equal_Button.UseVisualStyleBackColor = true;
            this.Equal_Button.Click += new System.EventHandler(this.Equal_Click);
            // 
            // BackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.Pclac);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Ptimer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("궁서", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BackGround";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "뒤틀린 황천의 계산타이머";
            this.Load += new System.EventHandler(this.BackGround_Load);
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            this.Timer.ResumeLayout(false);
            this.Timer.PerformLayout();
            this.Pclac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Calculator;
        private System.Windows.Forms.GroupBox Timer;
        private System.Windows.Forms.Panel Ptimer;
        private System.Windows.Forms.Panel Pclac;
        private System.Windows.Forms.Label Byproduction2;
        private System.Windows.Forms.Label ByProduction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textbox_Result;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button Equal_Button;
    }
}

