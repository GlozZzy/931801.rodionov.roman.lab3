using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lab2_3.Models
{
    public class QuizModel
    {
        public double val1;
        public double val2;

        string[] ListOperations = { "+", "-", "*", "/" };
        public string curOper;
        
        public double answer;
        public int userAnswer;
        public List<string> ListAnswers;

        public int count;
        public int rightcount;

        public static QuizModel Instance = new QuizModel();

        public void Reset()
        {
            count = 0;
            rightcount = 0;
            ListAnswers = new List<string>();
        }


        public void Start()
        {
            Random rand = new Random();
            val1 = rand.Next(0, 10);
            val2 = rand.Next(0, 10);
            curOper = ListOperations[rand.Next(0, 3)];
            count++;
        }
        

        public void Check()
        {
            switch (curOper)
            {
                case "+":
                    answer = val1 + val2;
                    if (answer == userAnswer)
                        rightcount++;
                    ListAnswers.Add("" + val1 + " + " + val2 + " = " + userAnswer);
                    break;
                case "-":
                    answer = val1 - val2;
                    if (answer == userAnswer)
                        rightcount++;
                    ListAnswers.Add("" + val1 + " - " + val2 + " = " + userAnswer);
                    break;
                case "*":
                    answer = val1 * val2;
                    if (answer == userAnswer)
                        rightcount++;
                    ListAnswers.Add("" + val1 + " * " + val2 + " = " + userAnswer);
                    break;
                case "/":
                    if (val2 != 0)
                    {
                        answer = val1 / val2;
                        if (answer == userAnswer)
                            rightcount++;
                        ListAnswers.Add("" + val1 + " / " + val2 + " = " + userAnswer);
                    }
                    break;
            }
        }
    }
}
