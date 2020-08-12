namespace Calc
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
            this.Timer = new System.Windows.Forms.GroupBox();
            this.Ptimer = new System.Windows.Forms.Panel();
            this.Byproduction2 = new System.Windows.Forms.Label();
            this.Pclac = new System.Windows.Forms.Panel();
            this.ByProduction = new System.Windows.Forms.Label();
            this.Ptimer.SuspendLayout();
            this.Pclac.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Calculator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Calculator.ForeColor = System.Drawing.Color.Black;
            this.Calculator.Location = new System.Drawing.Point(0, 0);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(500, 600);
            this.Calculator.TabIndex = 0;
            this.Calculator.TabStop = false;
            this.Calculator.Text = "계산기";
            // 
            // Timer
            // 
            this.Timer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Timer.ForeColor = System.Drawing.Color.Black;
            this.Timer.Location = new System.Drawing.Point(661, 36);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(500, 600);
            this.Timer.TabIndex = 1;
            this.Timer.TabStop = false;
            this.Timer.Text = "타이머";
            // 
            // Ptimer
            // 
            this.Ptimer.Controls.Add(this.Byproduction2);
            this.Ptimer.Location = new System.Drawing.Point(661, 36);
            this.Ptimer.Name = "Ptimer";
            this.Ptimer.Size = new System.Drawing.Size(503, 594);
            this.Ptimer.TabIndex = 2;
            // 
            // Byproduction2
            // 
            this.Byproduction2.AutoSize = true;
            this.Byproduction2.Location = new System.Drawing.Point(370, 572);
            this.Byproduction2.Name = "Byproduction2";
            this.Byproduction2.Size = new System.Drawing.Size(127, 19);
            this.Byproduction2.TabIndex = 6;
            this.Byproduction2.Text = "made by 수용";
            // 
            // Pclac
            // 
            this.Pclac.Controls.Add(this.ByProduction);
            this.Pclac.Controls.Add(this.Calculator);
            this.Pclac.Location = new System.Drawing.Point(15, 30);
            this.Pclac.Name = "Pclac";
            this.Pclac.Size = new System.Drawing.Size(500, 600);
            this.Pclac.TabIndex = 3;
            // 
            // ByProduction
            // 
            this.ByProduction.AutoSize = true;
            this.ByProduction.Location = new System.Drawing.Point(367, 578);
            this.ByProduction.Name = "ByProduction";
            this.ByProduction.Size = new System.Drawing.Size(127, 19);
            this.ByProduction.TabIndex = 5;
            this.ByProduction.Text = "made by 동준";
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
            this.Ptimer.ResumeLayout(false);
            this.Ptimer.PerformLayout();
            this.Pclac.ResumeLayout(false);
            this.Pclac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Calculator;
        private System.Windows.Forms.GroupBox Timer;
        private System.Windows.Forms.Panel Ptimer;
        private System.Windows.Forms.Panel Pclac;
        private System.Windows.Forms.Label Byproduction2;
        private System.Windows.Forms.Label ByProduction;
    }
}

