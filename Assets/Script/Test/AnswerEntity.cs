using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Test
{
    public class AnswerEntity : MonoBehaviour
    {
        public Answer answer;
        public Text displayContent;

        private void Awake()
        {
            displayContent = gameObject.GetComponentInChildren<Text>();
        }

        private void Start()
        {
            displayContent.text = answer.content;
        }
    }
}
