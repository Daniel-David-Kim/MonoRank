using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoRank.org.monorank.vo;
using MonoRank.org.monorank.service;
using MonoRank.org.monorank.common;
using System.Windows.Forms;

namespace MonoRank.org.monorank.controller
{
    internal class MemberController
    {
        private MemberService service = new MemberService();
        public Dictionary<string, object> RequestLogin(string id, string pw)
        {
            return service.Login(id, pw);
        }
        public bool TestNewIdContact(string info, string category)
        {
            return !service.CheckIdContactExists(info, category);
        }
        public bool RegisterMember(MemberVO newbie)
        {
            return service.EnrollNewMember(newbie);
        }
        public bool UpdateMember(MemberVO revise, Tester.MemberAction action=Tester.MemberAction.M_MODIFY)
        {
            return service.UpdateMember(revise, action);
        }
        public Dictionary<string, object> FindAccountId(string name, string contact)
        {
            return service.FindIdByNameContact(name, contact);
        }
        public Dictionary<string, object> GetUserQInfo(string id)
        {
            return service.GetUserById(id);
        }
        public Dictionary<string, object> GetMembersInfo()
        {
            return service.GetMembersDict();
        }
        public bool RemoveMember(string id)
        {
            return service.RemoveMember(id);
        }
        public MemberVO GetMemberById(string id)
        {
            return service.GetMemberById(id);
        }
    }
}
