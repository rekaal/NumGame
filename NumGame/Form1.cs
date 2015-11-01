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
        private List<int> UserAnswer = new List<int>();

        public Form1()
        {
            InitializeComponent();
            Game.answer = Game.CreateNumbers();//創造隨機4位數字
            rndNum.Text = Game.ConvertNumbersToString(Game.answer);//rndNum.Text欄位 = rndAnswer清單轉換為字串
        }

        private void enter_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int UserAns = 0;
            int.TryParse(textBox1.Text, out UserAns);
            if (textBox1.Text.Length < 4)//判斷玩家輸入數字數量
            { }
            else
            {
                UserAnswer.Add(UserAns);
            }//加入清單UserAnswer
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