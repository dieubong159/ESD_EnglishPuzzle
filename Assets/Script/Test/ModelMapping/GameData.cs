using Assets.Script.Test.ModelMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script.Test
{
    [System.Serializable]
    public class GameData
    {
        public Level[] levels;

        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            foreach (Level lv in levels)
            {
                temp.AppendLine(lv.ToString());
            }
            return temp.ToString();
        }
    }



    
}
