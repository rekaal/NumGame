using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumGame
{
    public partial class Form1 : Form
    {
        public Game Game = new Game();
        public List<int> UserAnswer = new List<int>();
        public int index = 0;

        public Form1()
        {
            InitializeComponent();
            Game.answer = Game.CreateNumbers();//創造隨機4位數字
            rndNum.Text = Game.ConvertNumbersToString(Game.answer);//rndNum.Text欄位 = rndAnswer清單轉換為字串
        }

        private void enter_Click(object sender, EventArgs e)
        {
            resultList.Text = UserAnswer + Game.GetResult(Game.answer);
            //resultList.Text = Game.ConvertNumbersToString(UserAnswer);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int UserAns = 0;
            int.TryParse(textBox1.Text, out UserAns);
            if (textBox1.Text.Length < 4)//判斷玩家輸入數字數量
            { }
            else if (textBox1.Text.Length == 4)
            { UserAnswer.Add(UserAns); }
            else
            { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.IndexOf(e.KeyChar) >= 0)
            {
                e.Handled = true;
                MessageBox.Show("請輸入4個不重複數字");
            }
        }
    }
}