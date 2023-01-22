using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EcoGame
{
    public class QuestManager : MonoBehaviour
    {
        private Quest q;

        public void CreateQuest()
        {
            this.q = new Quest();
            this.q.OnComplete += CreateQuest;
        }

        public void Start()
        {
            CreateQuest();
        }
    }
};
