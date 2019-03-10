using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 카톡_분석기
{
    public partial class FindFile : Form
    {
        public FindFile()
        {
            InitializeComponent();
        }

        private void openChatDialogBT_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == OpenChatDialog.ShowDialog())
            {
                FilePathTB.Text = OpenChatDialog.FileName;//채팅파일의 경로를 지정한다
            }
        }

        private void startAnalysisBT_Click(object sender, EventArgs e)
        {
            ChatAnaliser analiserBody = new ChatAnaliser(FilePathTB.Text);
            try
            {
                analiserBody.ShowDialog();// 로딩창겸 메세지들을 분석해서 유저별로 저장시키는 폼
            }
            catch (ObjectDisposedException)
            {
                //chatAnaliser 폼을 close하면 예외가 발생해서 막아둠
            }
        }
    }
}
