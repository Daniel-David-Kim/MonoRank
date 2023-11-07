using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoRank.org.monorank.vo;
using MonoRank.org.monorank.dao;
using MonoRank.org.monorank.common;

namespace MonoRank.org.monorank.service
{
    internal class MemberService
    {
        private MemberDAO dao = new MemberDAO();
        public static List<string> scoreTbls;
        private List<int> scoreRes = new List<int>();
        public MemberService() {
            scoreTbls = DBExecutor.ScoreTbls;
        }
        public Dictionary<string, object> Login(string id, string pw)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            MemberVO member = dao.FindMemberByIdPw(id, pw);
            if (member == null) result.Add("login", false);
            else
            {
                result.Add("login", true);
                result.Add("member", member);
            }
            return result;
        }
        public bool CheckIdContactExists(string info, string category) {
            return dao.SelectExistingIdContact(info, category);
        }
        public bool EnrollNewMember(MemberVO newbie)
        {
            bool success = true;
            int member = dao.InsertMember(newbie);
            foreach (string score in scoreTbls) {
                int temp = dao.InsertInitScore(newbie, score);
                if (temp != 1) success = false;
            }
            return (member == 1) && success;
        }
        public bool UpdateMember(MemberVO revise, Tester.MemberAction action)
        {
            bool success = true;
            int updateRow = dao.UpdateMember(revise);
            if(action == Tester.MemberAction.A_UPDATE) {
                foreach(string score in scoreTbls) {
                    int temp = dao.UpdateScore(revise, score);
                    if (temp != 1) success = false;
                }
            }
            return (updateRow == 1) && success;
        }
        public Dictionary<string, object> FindIdByNameContact(string name, string contact)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            MemberVO res = dao.FindIdByNameContact(name, contact);
            result.Add("find", res == null?false:true);
            if (res != null) result.Add("result", res);
            return result;
        }
        public Dictionary<string, object> GetUserById(string id)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            MemberVO res = dao.GetUserById(id);
            result.Add("get", res == null ? false : true);
            if (res != null) result.Add("question", res);
            return result;
        }
        public Dictionary<string, object> GetMembersDict()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            List<MemberVO> membersList = dao.GetMembersList();
            result.Add("rowCount", membersList.Count);
            result.Add("membersList", membersList);
            return result;
        }
        public bool RemoveMember(string id) {
            return dao.DeleteMember(id) == 1;
        }
        public MemberVO GetMemberById(string id) {
            return dao.SelectMemberById(id);
        }
    }
}
