using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoRank.Forms;
using System.Configuration;
using MonoRank.org.monorank.vo;

namespace MonoRank.org.monorank.common
{
    // 로그인과 페이지 이동에 관한 처리를 해주는 객체입니다. 웹의 Session에서 확장된 역할이라 보시면 됩니다.
    public class Arbiter
    {
        public Index Idx { get; set; }
        public Form PrevPage { get; set; } = null;
        public Form CurPage { get; set; }
        public MemberVO User { get; set; }
        // 게임별 숫자 코드를 모아놓은 열거형
        public enum GameCode {
            EATCOOKIE=0, ASSAULTCRAFT=1
        }
        // 열거형에 맞춰서 App.config에 지정해놓은 유니티 게임 파일을 가져올 수 있다.
        public Dictionary<GameCode, string> GameInfo = new Dictionary<GameCode, string>() {
            [GameCode.EATCOOKIE] = ConfigurationManager.AppSettings["eatcookie"],
            [GameCode.ASSAULTCRAFT] = ConfigurationManager.AppSettings["assaultcraft"]
        };
        public GameCode CurGameCode { get; set; } = GameCode.EATCOOKIE;
        public void RemovePrevPage()
        {
            if(PrevPage != null) PrevPage.Dispose();
            PrevPage = null;
        }
        public void Logout()
        {
            User = null;
            MessageBox.Show("성공적으로 로그아웃되었습니다.");
            Idx.retArbiter = this;
            Idx.Visible = true;
        }
    }
}
