using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using MonoRank.org.monorank.common;
using MonoRank.org.monorank.controller;
using System.Runtime.InteropServices;
using System.Configuration;
using MonoRank.org.monorank.vo;
using System.Runtime.Serialization.Json;

namespace MonoRank.Forms
{
    public partial class Game : Form
    {
        private Process game;
        private Arbiter arbiter;
        private string gameName;
        private IntPtr unityHwnd = IntPtr.Zero;
        private int ACTIVATE = 0x0006;
        private IntPtr WD_ACTIVE = new IntPtr(1);
        private IntPtr WD_DEACTIVE = new IntPtr(0);
        private NamedPipeServerStream server;
        private MemberController controller = new MemberController();
        private delegate int WinEnum(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int uMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern bool EnumChildWindows(IntPtr hWnd, WinEnum proc, IntPtr lParam);

        private void ExecuteIPC()
        {
            using NamedPipeServerStream server = new NamedPipeServerStream("MonoRankPipe", PipeDirection.Out);
            server.WaitForConnection();
            Member member = new Member() { Id=arbiter.User.Id, Name=arbiter.User.Name };
            switch (arbiter.CurGameCode)
            {
                case Arbiter.GameCode.EATCOOKIE:
                    member.Score = arbiter.User.Eatcookie; break;
                case Arbiter.GameCode.ASSAULTCRAFT:
                    member.Score = arbiter.User.Assaultcraft; break;
            }
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Member));
            serializer.WriteObject(server, member);
        }

        public Game()
        {
            InitializeComponent();
        }

        public Game(Arbiter arbiter) : this()
        {
            this.arbiter = arbiter;
            arbiter.RemovePrevPage();
            switch(arbiter.CurGameCode)
            {
                case Arbiter.GameCode.EATCOOKIE:
                    gameName = ConfigurationManager.AppSettings["eatcookie"]; break;
                case Arbiter.GameCode.ASSAULTCRAFT:
                    gameName = ConfigurationManager.AppSettings["assaultcraft"]; break;
            }
            Thread pipeThread = new Thread(ExecuteIPC);
            pipeThread.Start();
            game = new Process();
            game.StartInfo.FileName = gameName;
            game.StartInfo.Arguments = "-parentHWND " + gamePanel.Handle.ToInt32();
            game.EnableRaisingEvents = true;
            game.Exited += new EventHandler(ProcessTerminated);
            game.Start();
            game.WaitForInputIdle();
            Thread.Sleep(500);

            EnumChildWindows(gamePanel.Handle, MonoEnum, IntPtr.Zero);
        }

        int MonoEnum(IntPtr hWnd, IntPtr lParam)
        {
            this.unityHwnd = hWnd;
            return 0;
        }

        private void Game_Activated(object sender, EventArgs e)
        {
            if(!game.HasExited) {
                Console.WriteLine("game : Act");
                SendMessage(unityHwnd, ACTIVATE, WD_ACTIVE, IntPtr.Zero);
            } 
        }

        private void Game_Deactivate(object sender, EventArgs e)
        {
            if (!game.HasExited)
            {
                Console.WriteLine("game : DeAct");
                SendMessage(unityHwnd, ACTIVATE, WD_DEACTIVE, IntPtr.Zero);
            } 
        }

        private void ProcessTerminated(object sender, EventArgs e)
        {
            MessageBox.Show("게임이 종료되었습니다.");
          
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("game : closing");
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("game : closed");
            arbiter.PrevPage = this;
            MainForm gameSel = new MainForm(arbiter);
            arbiter.CurPage = gameSel;
            gameSel.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            arbiter.PrevPage = this;
            MainForm gameSel = new MainForm(arbiter);
            arbiter.CurPage = gameSel;
            gameSel.Show();
        }

        private void gamePanel_Click(object sender, EventArgs e)
        {
            // 화면을 누르면 메인 페이지로 돌아간다.
            //
            MemberVO refresh = controller.GetMemberById(arbiter.User.Id);
            arbiter = new Arbiter() { Idx = arbiter.Idx, User = refresh, PrevPage = this };
            //
            //arbiter.PrevPage = this;
            MainForm gameSel = new MainForm(arbiter);
            arbiter.CurPage = gameSel;
            gameSel.Show();
        }

        [Serializable]
        class Member
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Score { get; set; }
        }

    }
}
