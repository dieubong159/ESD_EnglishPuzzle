using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script.Test.ModelMapping
{
    [System.Serializable]
    public class Level 
    {
        public int level;
        public QuestionBase[] questions;

        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            temp.AppendLine("Level : " + level);
            foreach(QuestionBase question in questions)
            {
                temp.AppendLine(question.ToString());
            }
            return temp.ToString();
        }
    }
}
