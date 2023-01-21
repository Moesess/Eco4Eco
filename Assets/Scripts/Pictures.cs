
using EcoGame.Buildings;
using System.Collections.Generic;
using UnityEngine;

namespace Ecogame
{
    public class Pictures : MonoBehaviour
    {
        //[SerializeField] public Texture2D BudgetPicture;
        //[SerializeField] public Texture2D TrashPicture;
        //[SerializeField] public Texture2D EnergyPicture;
        //[SerializeField] public Texture2D FoodPicture;
        //[SerializeField] public Texture2D GoodsPicture;
        //[SerializeField] public Texture2D OilPicture;
        //[SerializeField] public Texture2D CoalPicture;
        //[SerializeField] public Texture2D GasPicture;
        //[SerializeField] public Texture2D UraniumPicture;
        //[SerializeField] public Texture2D PeatPicture;

        //[SerializeField] public Texture2D PeatMine;
        //[SerializeField] public Texture2D CoalMine;
        //[SerializeField] public Texture2D OilMine;
        //[SerializeField] public Texture2D GasMine;
        //[SerializeField] public Texture2D UraniumMine;

        [SerializeField] public Texture2D[] m_BuildingPictures;
        [SerializeField] public Texture2D[] m_ResourcePictures;


        public static Pictures Instance;
        public Dictionary<int, Texture2D> BuildingPictures = new();
        public Dictionary<BUILDINGS, Texture2D> ResourcePictures = new();

        public void Awake()
        {
            if (Instance == null)
            {
                foreach (BUILDINGS building in (BUILDINGS[])System.Enum.GetValues(typeof(BUILDINGS)))
                {
                    BuildingPictures.Add((int)building, m_BuildingPictures[(int)building]);
                }

                Instance = this;
            }
        }
    }

}
