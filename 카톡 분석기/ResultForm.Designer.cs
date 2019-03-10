namespace 카톡_분석기
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserNameLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SimpleInfoRB = new System.Windows.Forms.RadioButton();
            this.OftenWordRB = new System.Windows.Forms.RadioButton();
            this.EntireChatRB = new System.Windows.Forms.RadioButton();
            this.StartAnalyseBT = new System.Windows.Forms.Button();
            this.AnalyseRangeCB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserNameLB);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "유저 목록";
            // 
            // UserNameLB
            // 
            this.UserNameLB.BackColor = System.Drawing.SystemColors.Control;
            this.UserNameLB.FormattingEnabled = true;
            this.UserNameLB.ItemHeight = 15;
            this.UserNameLB.Location = new System.Drawing.Point(6, 24);
            this.UserNameLB.Name = "UserNameLB";
            this.UserNameLB.Size = new System.Drawing.Size(188, 424);
            this.UserNameLB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.StartAnalyseBT);
            this.groupBox2.Controls.Add(this.AnalyseRangeCB);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 460);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "옵션";
            // 
            // SimpleInfoRB
            // 
            this.SimpleInfoRB.AutoSize = true;
            this.SimpleInfoRB.Location = new System.Drawing.Point(7, 74);
            this.SimpleInfoRB.Name = "SimpleInfoRB";
            this.SimpleInfoRB.Size = new System.Drawing.Size(116, 19);
            this.SimpleInfoRB.TabIndex = 4;
            this.SimpleInfoRB.TabStop = true;
            this.SimpleInfoRB.Text = "간략한 정보?";
            this.SimpleInfoRB.UseVisualStyleBackColor = true;
            // 
            // OftenWordRB
            // 
            this.OftenWordRB.AutoSize = true;
            this.OftenWordRB.Location = new System.Drawing.Point(6, 49);
            this.OftenWordRB.Name = "OftenWordRB";
            this.OftenWordRB.Size = new System.Drawing.Size(113, 19);
            this.OftenWordRB.TabIndex = 3;
            this.OftenWordRB.TabStop = true;
            this.OftenWordRB.Text = "자주 쓴 단어";
            this.OftenWordRB.UseVisualStyleBackColor = true;
            // 
            // EntireChatRB
            // 
            this.EntireChatRB.AutoSize = true;
            this.EntireChatRB.Location = new System.Drawing.Point(6, 24);
            this.EntireChatRB.Name = "EntireChatRB";
            this.EntireChatRB.Size = new System.Drawing.Size(128, 19);
            this.EntireChatRB.TabIndex = 2;
            this.EntireChatRB.TabStop = true;
            this.EntireChatRB.Text = "전체 채팅 내용";
            this.EntireChatRB.UseVisualStyleBackColor = true;
            // 
            // StartAnalyseBT
            // 
            this.StartAnalyseBT.Location = new System.Drawing.Point(7, 418);
            this.StartAnalyseBT.Name = "StartAnalyseBT";
            this.StartAnalyseBT.Size = new System.Drawing.Size(75, 30);
            this.StartAnalyseBT.TabIndex = 1;
            this.StartAnalyseBT.Text = "출력";
            this.StartAnalyseBT.UseVisualStyleBackColor = true;
            this.StartAnalyseBT.Click += new System.EventHandler(this.StartAnalyseBT_Click);
            // 
            // AnalyseRangeCB
            // 
            this.AnalyseRangeCB.AutoSize = true;
            this.AnalyseRangeCB.Location = new System.Drawing.Point(7, 25);
            this.AnalyseRangeCB.Name = "AnalyseRangeCB";
            this.AnalyseRangeCB.Size = new System.Drawing.Size(94, 19);
            this.AnalyseRangeCB.TabIndex = 0;
            this.AnalyseRangeCB.Text = "전체 탐색";
            this.AnalyseRangeCB.UseVisualStyleBackColor = true;
            this.AnalyseRangeCB.CheckedChanged += new System.EventHandler(this.AnalyseRangeCB_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultTB);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 460);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "결과";
            // 
            // ResultTB
            // 
            this.ResultTB.BackColor = System.Drawing.SystemColors.Control;
            this.ResultTB.Location = new System.Drawing.Point(7, 18);
            this.ResultTB.Multiline = true;
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.ReadOnly = true;
            this.ResultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTB.Size = new System.Drawing.Size(668, 430);
            this.ResultTB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EntireChatRB);
            this.groupBox4.Controls.Add(this.SimpleInfoRB);
            this.groupBox4.Controls.Add(this.OftenWordRB);
            this.groupBox4.Location = new System.Drawing.Point(7, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 113);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "탐색 옵션";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox UserNameLB;
        private System.Windows.Forms.CheckBox AnalyseRangeCB;
        private System.Windows.Forms.Button StartAnalyseBT;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.RadioButton SimpleInfoRB;
        private System.Windows.Forms.RadioButton OftenWordRB;
        private System.Windows.Forms.RadioButton EntireChatRB;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}