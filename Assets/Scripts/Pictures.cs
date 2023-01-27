using EcoGame.Buildings;
using EcoGame.Resources;
using System.Collections.Generic;
using UnityEngine;

namespace EcoGame
{
    public class Pictures : MonoBehaviour
    {
        [SerializeField] public Texture2D[] m_BuildingPictures;
        [SerializeField] public Texture2D[] m_ResourcePictures;


        public static Pictures Instance;
        public Dictionary<int, Texture2D> BuildingPictures = new();
        public Dictionary<int, Texture2D> ResourcePictures = new();

        public void Awake()
        {
            if (Instance == null)
            {
                foreach (BUILDINGS building in (BUILDINGS[])System.Enum.GetValues(typeof(BUILDINGS)))
                {
                    BuildingPictures.Add((int)building, m_BuildingPictures[(int)building]);
                }

                foreach (RESOURCES resource in (RESOURCES[])System.Enum.GetValues(typeof(RESOURCES)))
                {
                    if (resource == RESOURCES.R_NULL || resource == RESOURCES.R_POLLUTION_MAXIMUM) continue;
                    ResourcePictures.Add((int)resource, m_ResourcePictures[(int)resource]);
                }
                
                Instance = this;
            }
        }
    }

}
