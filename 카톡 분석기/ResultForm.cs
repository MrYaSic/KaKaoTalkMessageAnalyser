using System;
using System.Collections;
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
    public partial class ResultForm : Form
    {
        List<UserInfo> userInfos;
        StringBuilder entireChat;

        public ResultForm(List<UserInfo> userInfos,StringBuilder entireChat)
        {
            InitializeComponent();
            this.userInfos = userInfos;
            ReloadUserName();
            this.entireChat = entireChat;
        }

        void ReloadUserName()//userNameLB를 갱신한다
        {
            UserNameLB.Items.Clear();
            List<string> temp = new List<string>();
            foreach(UserInfo user in userInfos)
            {
                temp.Add(user.UserName);//이름을 하나하나 리스트에 추가한다음
            }
            UserNameLB.Items.AddRange(temp.ToArray());//한방에 집어 넣는다
            UserNameLB.SelectedIndex = 0;//유저가 대상을 선택하지 않고 탐색을 시작하는것을 방지하기 위해 선택의 기본값을 정해준다.
        }

        private void AnalyseRangeCB_CheckedChanged(object sender, EventArgs e)
        {
            UserNameLB.Enabled = !(AnalyseRangeCB.Checked);//전체 탐색이 활성화 되면 리스트박스는 비활성화 시킨다
        }

        private void StartAnalyseBT_Click(object sender, EventArgs e)
        {
            if (EntireChatRB.Checked)
            {
                //해당 유저(또는 전체의) 전체 채팅내용을 출력하는 메서드
                PrintEntireChat();
            }
            else if (OftenWordRB.Checked)
            {
                //자주쓴 단어를 빈도가 높은순으로 출력하는 메서드 [ {해당 문자} (갯수) ]포맷으로 출력할 예정
                OftenWord();
            }
            else if (SimpleInfoRB.Checked)
            {
                //사용자에 대한 간략한 정보 출력을 위한 칸인데.. 무엇 무엇을 출력해야할지 모르겠다 ㅎㅎ
                SimpleInfo();
            }
            else
            {
                MessageBox.Show("탐색옵션을 선택해 주세요");
            }
        }

        void PrintEntireChat()
        {
            if (AnalyseRangeCB.Checked)
            {
                ResultTB.Text = entireChat.ToString();
            }
            else
            {
                StringBuilder UsersEntireMessage = new StringBuilder();
                string SelectedUserName = (string)UserNameLB.SelectedItem;//왠지 foreach안에 넣으면 언박싱을 계속해댈거 같으니 빼내자..
                foreach (var user in userInfos)
                {
                    if(user.UserName == SelectedUserName)
                    {
                        foreach(string messageLine in user.MessageList)
                        {
                            UsersEntireMessage.AppendLine($"[{user.UserName}] {messageLine}");
                        }
                        ResultTB.Text = UsersEntireMessage.ToString();
                        break;
                    }
                }
            }
        }

        void OftenWord()
        {
            List<NumberOfWord> numberOfWords = new List<NumberOfWord>();

            if (AnalyseRangeCB.Checked)//전체 탐색
            {
                // 데이터 추출과정(?)
                foreach(UserInfo user in userInfos)//이거 어떻게 간략화 못시킬려나.. LINQ는 아직 덜익숙해져서 이런게 될지를 모르겠네 ㅎㅎ
                {
                    foreach(string message in user.MessageList)
                    {
                        string[] words = message.Split(' ');
                        foreach(string word in words)
                        {
                            foreach(NumberOfWord temp in numberOfWords)
                            {
                                if(temp.Word == word)//만약 이 단어가 이미 한번 나온 단어이면 카운트를 올리고
                                {
                                    temp.Count++;
                                    goto AAA;
                                }
                            }
                            numberOfWords.Add(new NumberOfWord() { Word = word, Count = 1 });//아니라면 하나 등록해준다 ㅎㅎ
                            AAA:;
                        }
                    }
                }
                
                var Result = from temp in numberOfWords
                                            where temp.Count >= 3 //세번도 안나온 단어는 걍 버리자
                                            orderby temp.Count descending
                                            select temp;

                // 데이터 출력과정(?)
                StringBuilder oftenWordString = new StringBuilder();
                foreach (var temp in Result)
                {
                    oftenWordString.AppendLine($"{temp.Word} ({temp.Count}번)");
                }
                ResultTB.Text = oftenWordString.ToString();
            }
            //자주쓴단어 전체탐색이아닌 개별탐색
            else
            {
                foreach(UserInfo user in userInfos)
                {
                    if (user.UserName == UserNameLB.SelectedItem.ToString())
                    {
                        foreach (string message in user.MessageList)
                        {
                            string[] words = message.Split(' ');
                            foreach (string word in words)
                            {
                                foreach (NumberOfWord temp in numberOfWords)
                                {
                                    if (temp.Word == word)//만약 이 단어가 이미 한번 나온 단어이면 카운트를 올리고
                                    {
                                        temp.Count++;
                                        goto AAA;
                                    }
                                }
                                numberOfWords.Add(new NumberOfWord() { Word = word, Count = 1 });//아니라면 하나 등록해준다 ㅎㅎ
                                AAA:;
                            }
                        }
                        break;
                    }
                }

                var Result = from temp in numberOfWords
                             where temp.Count >= 3
                             orderby temp.Count descending
                             select temp;

                // 데이터 출력과정(?)
                StringBuilder oftenWordString = new StringBuilder();
                foreach (var temp in Result)
                {
                    oftenWordString.AppendLine($"{temp.Word} ({temp.Count}번)");
                }
                ResultTB.Text = oftenWordString.ToString();
            }
        }

        void SimpleInfo()
        {
            if (AnalyseRangeCB.Checked)
            {
                int MessageCount = 0;
                foreach(UserInfo user in userInfos)
                {
                    MessageCount += user.MessageList.Count;
                }

                ResultTB.Text =
                    $"인원 : {UserNameLB.Items.Count} {Environment.NewLine}" +
                    $"메세지 개수 : {MessageCount} {Environment.NewLine}";
            }
            else
            {
                UserInfo user = new UserInfo() { UserName = "Unknown", MessageList = new List<string>() };

                foreach(UserInfo temp in userInfos)
                {
                    if(temp.UserName == UserNameLB.SelectedItem.ToString())
                    {
                        user = temp;
                    }
                }

                ResultTB.Text =
                    $"이름 : {user.UserName} {Environment.NewLine}" +
                    $"메세지 개수 : {user.MessageList.Count} {Environment.NewLine}";
            }
        }
    }
}
