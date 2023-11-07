using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MonoRank.org.monorank.common;
using MonoRank.org.monorank.vo;

namespace MonoRank.org.monorank.dao
{
    internal class MemberDAO
    {
        public MemberVO FindMemberByIdPw(string id, string pw)
        {
            MemberVO result = null;
            string sql = $"select m.id, pwd, name, findq, finda, contact, admin, r.score as eatcookie, s.score as assaultcraft from member m inner join eatcookie r on m.id=r.id inner join assaultcraft s on m.id=s.id where m.id='{id}' and m.pwd='{pw}'";
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            using MySqlDataReader rs = command.ExecuteReader();
            if(rs.Read()) result = new MemberVO() { Id=rs["id"].ToString(), Pwd=rs["pwd"].ToString(), Name=rs["name"].ToString(), Findq=rs["findq"].ToString(), Finda=rs["finda"].ToString(), Contact=rs["contact"].ToString(), Admin=rs.GetInt32("admin"), Eatcookie=rs.GetInt32("eatcookie"), Assaultcraft=rs.GetInt32("assaultcraft") };
            return result;
        }
        public bool SelectExistingIdContact(string info, string category)
        {
            bool result = false;
            string sql = String.Format("select * from member where {0}='{1}'", category, info);
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            using MySqlDataReader rs = command.ExecuteReader();
            if (rs.Read()) result = true;
            return result;
        }
        public int InsertMember(MemberVO newbie)
        {
            int result = 0;
            string sql = String.Format("insert into member values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})", newbie.Id, newbie.Pwd, newbie.Name, newbie.Findq, newbie.Finda, newbie.Contact, newbie.Admin);
            Console.WriteLine("sql : {0}", sql);
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            result = command.ExecuteNonQuery();
            return result;
        }

        public int InsertInitScore(MemberVO newbie, string tbName)
        {
            int result = 0;
            int score;
            switch(tbName) {
                case "eatcookie": score = newbie.Eatcookie; break;
                case "assaultcraft": score = newbie.Assaultcraft; break;
                default: score = 0; break;
            }
            string sql = $"insert into {tbName} values ('{newbie.Id}', {score})";
            Console.WriteLine("sql : {0}", sql);
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            result = command.ExecuteNonQuery();  
            return result;
        }
        public MemberVO FindIdByNameContact(string name, string contact)
        {
            MemberVO result = null;
            string sql = $"select id from member where name='{name}' and contact='{contact}'";
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            using MySqlDataReader rs = command.ExecuteReader();
            if(rs.Read()) result = new MemberVO() { Id=rs["id"].ToString() };
            return result;
        }
        public MemberVO GetUserById(string id)
        {
            MemberVO result = null;
            string sql = $"select id, pwd, findq, finda from member where id='{id}'";
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            using MySqlDataReader rs = command.ExecuteReader();
            if (rs.Read()) result = new MemberVO() { Id=rs["id"].ToString(), Pwd=rs["pwd"].ToString(), Findq=rs["findq"].ToString(), Finda=rs["finda"].ToString() };
            return result;
        }
        public List<MemberVO> GetMembersList()
        {
            List<MemberVO> result = new List<MemberVO>();
            string sql = "select m.id, pwd, name, findq, finda, contact, admin, r.score as eatcookie, s.score as assaultcraft from member m inner join eatcookie r on m.id=r.id inner join assaultcraft s on m.id=s.id";
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            using MySqlDataReader rs = command.ExecuteReader();
            while (rs.Read()) result.Add(new MemberVO { Id=rs["id"].ToString(), Pwd=rs["pwd"].ToString(), Name=rs["name"].ToString(), Findq=rs["findq"].ToString(), Finda=rs["finda"].ToString(), Contact=rs["contact"].ToString(), Admin=(int)rs["admin"], Eatcookie=(int)rs["eatcookie"], Assaultcraft=(int)rs["assaultcraft"] });
            return result;
        }
        public int UpdateMember(MemberVO revise)
        {
            string sql = $"update member set pwd='{revise.Pwd}', name='{revise.Name}', findq='{revise.Findq}', finda='{revise.Finda}', contact='{revise.Contact}', admin={revise.Admin} where id='{revise.Id}'";
            Console.WriteLine("sql : {0}", sql);
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            return command.ExecuteNonQuery();
        }
        public int UpdateScore(MemberVO revise, string tbName)
        {
            int score;
            switch (tbName) {
                case "eatcookie": score = revise.Eatcookie; break;
                case "assaultcraft": score = revise.Assaultcraft; break;
                default: score = 0; break;
            }
            string sql = $"update {tbName} set score={score} where id='{revise.Id}'";
            Console.WriteLine("sql : {0}", sql);
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            return command.ExecuteNonQuery();
        }
        public int DeleteMember(string id)
        {
            string sql = $"delete from member where id='{id}'";
            Console.WriteLine("sql : {0}", sql);
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            return command.ExecuteNonQuery();
        }
        public MemberVO SelectMemberById(string id)
        {
            MemberVO result = null;
            string sql = $"select m.id, pwd, name, findq, finda, contact, admin, r.score as eatcookie, s.score as assaultcraft from member m inner join eatcookie r on m.id=r.id inner join assaultcraft s on m.id=s.id where m.id='{id}'";
            using MySqlConnection conn = DBExecutor.GetConnection();
            using MySqlCommand command = new MySqlCommand(sql, conn);
            using MySqlDataReader rs = command.ExecuteReader();
            if(rs.Read()) result = new MemberVO() { Id = rs["id"].ToString(), Pwd = rs["pwd"].ToString(), Name = rs["name"].ToString(), Findq = rs["findq"].ToString(), Finda = rs["finda"].ToString(), Contact = rs["contact"].ToString(), Admin = rs.GetInt32("admin"), Eatcookie = rs.GetInt32("eatcookie"), Assaultcraft = rs.GetInt32("assaultcraft") };
            return result;
        }
    }
}
