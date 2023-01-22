using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EcoGame
{
    public class Quest 
    {
        [System.Serializable]

        public struct Data //informacje dotyczace zadania 
        {
            public string name;
            public Texture2D picture;
            public string description;
            public int requiredAmount;
            public int currentAmount;
            public int targetKey;
            public bool building;
        }

        [Header("Data")] public Data data; //pole do informacji 

        public bool completed { get; protected set; } //czy wykonano zadanie
        
        public delegate void CompletedDelegate();
        public event CompletedDelegate OnComplete;

        public virtual void Initialize() // inizjalizacja
        {
            completed = false;
            if (Random.Range(0, 1) == 0)
            {
                data.building = false;
                getRandomResource();
                data.currentAmount = ResourceManager.Instance.Resources[data.targetKey].Amount;
                data.requiredAmount = calculateRequiredAmount(data.currentAmount);
                data.description = "Zdobπdü " + data.requiredAmount + " " + ResourceManager.Instance.Resources[data.targetKey].Name.ToLower();
                data.picture = Pictures.Instance.ResourcePictures[data.targetKey];
                ResourceManager.Instance.Resources[data.targetKey].OnAmountChange += CheckComplete;
            }
            else
            {
                data.building = true;
                data.targetKey = Random.Range(0, System.Enum.GetNames(typeof(Buildings.BUILDINGS)).Length);
                data.currentAmount = BuildingManager.Instance.Buildings[data.targetKey].Amount;
                data.requiredAmount = calculateRequiredAmount(data.currentAmount);
                data.description = "Wybuduj " + data.requiredAmount + " " + BuildingManager.Instance.Buildings[data.targetKey].Name.ToLower();
                data.picture = Pictures.Instance.BuildingPictures[data.targetKey];
                BuildingManager.Instance.Buildings[data.targetKey].OnIAmountChange += CheckComplete;
            }
            GameObject.Find("UI/Canvas/Center Panel/Left Panel/Quest Panel/Description").GetComponent<TMP_Text>().text = data.description;
            GameObject.Find("UI/Canvas/Center Panel/Left Panel/Quest Panel/Image").GetComponent<RawImage>().texture = data.picture;
        }

        private void getRandomResource()
        {
            data.targetKey = Random.Range(0, System.Enum.GetNames(typeof(Resources.RESOURCES)).Length - 2);
            if (data.targetKey == (int)Resources.RESOURCES.R_TRASH || data.targetKey == (int)Resources.RESOURCES.R_NULL || 
                data.targetKey == (int)Resources.RESOURCES.R_POLLUTION_MAXIMUM || data.targetKey == (int)Resources.RESOURCES.R_LEAF ||
                data.targetKey == (int)Resources.RESOURCES.R_HAPPY || data.targetKey == (int)Resources.RESOURCES.R_BUDGET ||
                data.targetKey == (int)Resources.RESOURCES.R_POLLUTION)
            {
                getRandomResource();
            }
        }

        private int calculateRequiredAmount(int currentAmount)
        {
            if (currentAmount == 0) return 10;
            return currentAmount * Random.Range(2, 4);
        }

        private int getCurrentAmount()
        {
            if(data.building == true)
            {
                return BuildingManager.Instance.Buildings[data.targetKey].Amount;
            }
            return ResourceManager.Instance.Resources[data.targetKey].Amount;
        }

        public void CheckComplete()
        {
            if (getCurrentAmount() >= data.requiredAmount)
            {
                if (data.building == true)
                {
                    BuildingManager.Instance.Buildings[data.targetKey].OnIAmountChange -= CheckComplete;
                }
                else
                {
                    ResourceManager.Instance.Resources[data.targetKey].OnAmountChange -= CheckComplete;
                }
                ResourceManager.Instance.Resources[(int)Resources.RESOURCES.R_HAPPY].Amount += 1;
                completed = true;
                //GameObject popUpWindow = UnityEngine.Resources.Load("Prefabs/Panels/Information Panel", typeof(GameObject)) as GameObject;
                //popUpWindow.Instantiate();
                //popUpWindow.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
                //popUpWindow.transform.Find("Text Group/Title").GetComponent<TMP_Text>().text = "Zadanie wykonano!";
                //popUpWindow.transform.Find("Text Group/Descritpion").GetComponent<TMP_Text>().text = "Wykona≥eú zadanie! Zadowolenie spo≥eczne roúnie.";
                if (OnComplete != null) OnComplete();
            }
        }

        public Quest()
        {
            Initialize();
        }
    }
};
