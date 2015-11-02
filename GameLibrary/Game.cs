using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        public List<int> answer = new List<int>();//增加一個清單answer
        private Random random = new Random();//設置隨機變數

        public string GetResult(List<int> userAnswer)//字串GetResult(清單-使用者答案)判斷幾A幾B
        {
            int aCount = 0;//aCount為0
            int bCount = 0;//bcount為0
            string result = "";//字串result=""
            for (int userAnswerIndex = 0; userAnswerIndex < 4; userAnswerIndex++)//for迴圈，從userAnswerIndex=0開始，小於4結束，每次UseranswerIndex+1
            {
                for (int answerIndex = 0; answerIndex < 4; answerIndex++)//for迴圈，從answerIndex=0開始，小於4結束，每次answerIndex+1
                {
                    if (userAnswer[userAnswerIndex] == this.answer[answerIndex])//如果userAnswer[userAnswerIndex]等於Answer[answerIndex]
                    {
                        if (userAnswerIndex == answerIndex)//A+1
                            aCount++;
                        else
                            bCount++;//B+1
                    }
                }
            }
            //result += "Game Answer:" + this.ConvertNumbersToString(this.answer) + "\n";
            result += "User Answer:" + this.ConvertNumbersToString(userAnswer) + "\n";
            return string.Format("\n{0}A{1}B", aCount, bCount);
        }

        public List<int> CreateNumbers()
        {
            List<int> numbers = new List<int>();//增加一個清單numbers

            do
            {
                int number = random.Next(1, 10);//產生一個1~9之間的數字
                if (!this.IsInAnswer(number, numbers))//如果這個數字不在numbers裡面
                    numbers.Add(number);//則增加一個數字
            } while (numbers.Count < 4);//如果number count小於4
            return numbers;//回傳至清單
        }

        private bool IsInAnswer(int number, List<int> numbers)//給一個數字，看是否有在清單裡頭
        {
            for (int index = 0; index < numbers.Count; index++)//index為0，index小於number的數量,index+1
            {
                if (number == numbers[index])//如果有，回傳trure
                {
                    return true;
                }
            }
            return false;
        }

        public string ConvertNumbersToString(List<int> numbers)//轉換清單Numbers為字串
        {
            string result = "";//字串result=""
            for (int index = 0; index < numbers.Count; index++)
                result += numbers[index].ToString();

            return result;
        }
    }
}