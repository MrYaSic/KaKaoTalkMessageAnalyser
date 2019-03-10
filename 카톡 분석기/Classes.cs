using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 카톡_분석기
{
    public class UserInfo//유저이름과 해당 유저가 전송한 메세지를 저장하는 클래스
    {
        public string UserName { get; set; }
        public List<string> MessageList { get; set; }
    }

    class NumberOfWord
    {
        public string Word { get; set; }
        public int Count { get; set; }
    }
}
