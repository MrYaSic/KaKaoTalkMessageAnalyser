using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 카톡_분석기
{
    public partial class ChatAnaliser : Form
    {
        public ChatAnaliser(string filePath)
        {
            InitializeComponent();
            CallResultForm(filePath);
        }


        void CallResultForm(string filePath)
        {
            StreamReader FileReader = null;
            try
            {
                FileReader = new StreamReader(filePath);
            }
            catch (ArgumentException)//파일을 열수 없는 경우
            {
                WrongFilePath();
                return;
            }
            catch(FileNotFoundException)
            {
                WrongFilePath();
                return;
            }
            catch (DirectoryNotFoundException)
            {
                WrongFilePath();
                return;
            }
            catch (IOException)
            {
                WrongFilePath();
                return;
            }

            List<UserInfo> UserInfoList = new List<UserInfo>();
            UserInfoList = AnalyseChat(FileReader);

            FileReader = new StreamReader(filePath);//analyseChat에서 스트림이 끝까지 이동해버렸기 때문에 스트림을 재할당해준다.. 스트림 위치만 옮길수는 없나?
            ResultForm resultForm = new ResultForm(UserInfoList,GetEntireChat(FileReader));//결과창을 띄우고 로딩창을 내린다
            FileReader.Close();//파일리더 해제
            resultForm.Show();
            this.Close();
        }

        List<UserInfo> AnalyseChat(StreamReader FileReader)//채팅기록 텍스트 파일을 정리
        {
            List<UserInfo> UserInfoList = new List<UserInfo>();

            while (FileReader.EndOfStream == false)
            {
                string stringLine = FileReader.ReadLine();
                if (!stringLine.StartsWith("[")) continue;//문자열이 '['로 시작하지 않는다면 시스템 문자이므로 무시

                string name, message;//이름정보와 메세지 정보
                bool IsExist = false;
                name = GetUserName(stringLine);
                message = GetMessage(stringLine);

                foreach (UserInfo user in UserInfoList)
                {
                    if (user.UserName == name)//유저가 이미 있다면 메세지 리스트만 갱신해준다
                    {
                        user.MessageList.Add(message);
                        IsExist = true;
                        break;
                    }
                }
                if (IsExist == false)//유저가 처음보는 유저라면 userInfo를 새로 만들어서 등록해준다
                {
                    UserInfo user = new UserInfo { UserName = name, MessageList = new List<string>() };
                    user.MessageList.Add(message);
                    UserInfoList.Add(user);
                }
            }

            return UserInfoList;
        }

        void WrongFilePath()
        {
            MessageBox.Show("파일경로가 잘못되었습니다");
            this.Close();
        }

        string GetUserName(string stringLine)
        {
            stringLine = stringLine.Remove(0, 1);
            string name = stringLine.Remove(stringLine.IndexOf(']'));//첫 ']'를 만나면 그 뒤로는 이름 값과 무관하므로 싹 날린다
            return name;
        }

        string GetMessage(string stringLine)
        {
            stringLine = stringLine.Remove(0, stringLine.IndexOf(']') + 1);//이것으로 이름정보를 날리고
            stringLine = stringLine.Remove(0, stringLine.IndexOf(']') + 1);//이것으로 시간정보를 날린다
            string message = stringLine.Trim();//앞뒤의 공백을 제거해준다
            return message;
        }

        StringBuilder GetEntireChat(StreamReader fileReader)//채팅텍스트 파일에서 이름 + 메세지를 한줄로 넣는다 전체 메세지 출력을 위함 
        {
            StringBuilder entireChat = new StringBuilder();
            while (!fileReader.EndOfStream)
            {
                string stringLine = fileReader.ReadLine();
                if (!stringLine.StartsWith("[")) continue;//문자열이 '['로 시작하지 않는다면 시스템 문자이므로 무시

                entireChat.AppendLine($"[{GetUserName(stringLine)}] {GetMessage(stringLine)}");
            }

            return entireChat;
        }
    }
}