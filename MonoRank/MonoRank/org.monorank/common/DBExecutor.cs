using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MonoRank.org.monorank.common
{
    public static class DBExecutor
    {
        private readonly static string SERVER = ConfigurationManager.AppSettings["Server"];
        private readonly static int PORT = int.Parse(ConfigurationManager.AppSettings["Port"]);
        private readonly static string DB = ConfigurationManager.AppSettings["DataBase"];
        private readonly static string UID = ConfigurationManager.AppSettings["Uid"];
        private readonly static string PWD = ConfigurationManager.AppSettings["Pwd"];
        // 여기에 서비스하고 있는 테이블 이름을 넣습니다.
        public static List<string> ScoreTbls { get; } = new List<string>() { "eatcookie", "assaultcraft" };
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", SERVER, PORT, DB, UID, PWD));
            conn.Open();
            return conn;
        }
    }
}
