namespace 카톡_분석기
{
    partial class FindFile
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
            this.OpenChatDialog = new System.Windows.Forms.OpenFileDialog();
            this.openChatDialogBT = new System.Windows.Forms.Button();
            this.FilePathTB = new System.Windows.Forms.TextBox();
            this.startAnalysisBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenChatDialog
            // 
            this.OpenChatDialog.FileName = "kakaotalkChat";
            this.OpenChatDialog.Filter = "카톡파일|*.txt";
            // 
            // openChatDialogBT
            // 
            this.openChatDialogBT.Location = new System.Drawing.Point(12, 12);
            this.openChatDialogBT.Name = "openChatDialogBT";
            this.openChatDialogBT.Size = new System.Drawing.Size(75, 26);
            this.openChatDialogBT.TabIndex = 0;
            this.openChatDialogBT.Text = "찾아보기";
            this.openChatDialogBT.UseVisualStyleBackColor = true;
            this.openChatDialogBT.Click += new System.EventHandler(this.openChatDialogBT_Click);
            // 
            // FilePathTB
            // 
            this.FilePathTB.Location = new System.Drawing.Point(93, 12);
            this.FilePathTB.Name = "FilePathTB";
            this.FilePathTB.Size = new System.Drawing.Size(407, 25);
            this.FilePathTB.TabIndex = 1;
            // 
            // startAnalysisBT
            // 
            this.startAnalysisBT.Location = new System.Drawing.Point(506, 12);
            this.startAnalysisBT.Name = "startAnalysisBT";
            this.startAnalysisBT.Size = new System.Drawing.Size(54, 26);
            this.startAnalysisBT.TabIndex = 2;
            this.startAnalysisBT.Text = "분석";
            this.startAnalysisBT.UseVisualStyleBackColor = true;
            this.startAnalysisBT.Click += new System.EventHandler(this.startAnalysisBT_Click);
            // 
            // FindFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 53);
            this.Controls.Add(this.startAnalysisBT);
            this.Controls.Add(this.FilePathTB);
            this.Controls.Add(this.openChatDialogBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindFile";
            this.Text = "카톡 분석기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenChatDialog;
        private System.Windows.Forms.Button openChatDialogBT;
        private System.Windows.Forms.TextBox FilePathTB;
        private System.Windows.Forms.Button startAnalysisBT;
    }
}

