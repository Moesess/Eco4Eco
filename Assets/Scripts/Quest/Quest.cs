using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace EcoGame
{
    public class Quest : MonoBehaviour
    {
        [System.Serializable]

        public struct Data //informacje dotyczace zadania 
        {
            public string name;
            public Texture2D picture;
            public string description;
            public int requiredAmount;
        }

        [Header("Data")] public Data data; //pole do informacji 

        public bool completed { get; protected set; } //czy wykonano zadanie
        private string targetKey;

        public virtual void Initialize() // inizjalizacja
        {
            completed = false;
            if (Random.Range(0, 1) == 0)
            {
                //targetKey = ResourceManager.Instance.Resources[Random.Range(0, 1)];
            }
            else
            {
                //targetKey = BuildingManager.Instance.Buildings[Random.Range(0, 1)];
            }
            //data.requiredAmount = CURRENTAMOUNT * Random.Range(2, 20);
        }

        public void CheckComplete(int currentAmount)
        {
            if (currentAmount >= data.requiredAmount)
            {
                Complete();
            }
        }

        private void Complete()
        {
            completed = true;
        }

        public void Start()
        {
            Initialize();
        }
    }
};
