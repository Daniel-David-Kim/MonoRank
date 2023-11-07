using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoRank.org.monorank.vo
{
    // 회원 정보에 대한 객체입니다. 
    public class MemberVO
    {
        public string Id { get; set; }
        public string Pwd { get; set; }
        public string Name { get; set; }
        public string Findq { get; set; }
        public string Finda { get; set; }
        public string Contact { get; set; }
        public int Admin { get; set; } = 0;
        public int Eatcookie { get; set; } = 0;
        public int Assaultcraft { get; set; } = 0;
        public override string ToString()
        {
            return String.Format("[{0} : {1}] ({2}) / {3} / {4} / {5} / {6} / {7} / {8}", Id, Pwd, Name, Findq, Finda, Contact, Admin, Eatcookie, Assaultcraft);
        }
    }
}