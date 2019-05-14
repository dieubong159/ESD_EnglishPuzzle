using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script.Test
{
    [System.Serializable]
    public class QuestionBase
    {
        public string question;
        public string type;
        public Answer[] answers;
        public Answer result;
        public string soundPath;
        public string imagePath;

        public QuestionBase(QuestionBase question)
        {
            this.question = question.question;
            this.type = question.type;
            this.answers = question.answers;
            this.result = question.result;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Question : " + question);
            stringBuilder.AppendLine("Type : " + type);
            stringBuilder.AppendLine("Sound Path : " + soundPath);
            stringBuilder.AppendLine("Image Path : " + imagePath);
            stringBuilder.AppendLine("Answers : ");
            
            foreach(Answer ans in answers)
            {
                stringBuilder.AppendLine(" - "+ans.ToString());
            }
            stringBuilder.AppendLine("Result : " + result);
            return stringBuilder.ToString();
        }
    }

   
}
