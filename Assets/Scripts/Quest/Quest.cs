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
            public int targetKey;
        }

        [Header("Data")] public Data data; //pole do informacji 

        public bool completed { get; protected set; } //czy wykonano zadanie

        public virtual void Initialize() // inizjalizacja
        {
            completed = false;
            if (Random.Range(0, 1) == 0)
            {
                data.targetKey = Random.Range(0, System.Enum.GetNames(typeof(Resources.RESOURCES)).Length);
                data.requiredAmount = ResourceManager.Instance.Resources[data.targetKey].Amount;
                data.description = "Zdobadz " + data.requiredAmount + ResourceManager.Instance.Resources[data.targetKey].Name;
                ResourceManager.Instance.Resources[data.targetKey].OnAmountChange += CheckComplete;
            }
            else
            {
                data.targetKey = Random.Range(0, System.Enum.GetNames(typeof(Buildings.BUILDINGS)).Length);
                data.requiredAmount = BuildingManager.Instance.Buildings[data.targetKey].Amount;
                data.description = "Wybuduj " + data.requiredAmount + BuildingManager.Instance.Buildings[data.targetKey].Name;
                BuildingManager.Instance.Buildings[data.targetKey].OnIAmountChange += CheckComplete;
            }
            data.requiredAmount *= Random.Range(2, 4);
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
