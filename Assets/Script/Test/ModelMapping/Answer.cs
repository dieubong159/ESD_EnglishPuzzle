using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script.Test
{
    [System.Serializable]
    public class Answer
    {
        public int id;
        public string content;
        public string imagePath;

        public override bool Equals(object obj)
        {
            Answer temp = (Answer)obj;
            if(temp.id == id)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Id : " + id + " | Content : " + content + " | " + imagePath;
        }
    }


}
