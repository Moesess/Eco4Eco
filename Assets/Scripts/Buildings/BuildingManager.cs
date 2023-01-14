using EcoGame;
using EcoGame.Buildings;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EcoGame
{
    public class BuildingManager : MonoBehaviour
    {
        public static BuildingManager Instance;
        public Dictionary<string, _BaseBuilding> Buildings = new();

        private void Start()
        {
            this.Buildings.Add(BuildingConsts.BUILDING_MINE_OIL, gameObject.AddComponent<OilMineBuilding>());
            this.Buildings.Add(BuildingConsts.BUILDING_MINE_COAL, gameObject.AddComponent<CoalMineBuilding>());
            this.Buildings.Add(BuildingConsts.BUILDING_MINE_GAS, gameObject.AddComponent<GasMineBuilding>());
            this.Buildings.Add(BuildingConsts.BUILDING_POWERPLANT, gameObject.AddComponent<PowerPlantBuilding>());
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
    }
}
