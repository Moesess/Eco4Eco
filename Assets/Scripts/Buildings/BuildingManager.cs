using EcoGame;
using EcoGame.Buildings;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
    public class BuildingManager : MonoBehaviour
    {
        [SerializeField] GameObject BuildingPrefab;

        public static BuildingManager Instance;
        public Dictionary<string, _BaseBuilding> Buildings = new();
        public Dictionary<string, GameObject> BuildingInstances = new();

        private void Awake()
        {
            if (Instance == null)
            {
                this.Buildings.Add(BuildingConsts.BUILDING_MINE_OIL, gameObject.AddComponent<OilMineBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_MINE_COAL, gameObject.AddComponent<CoalMineBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_MINE_GAS, gameObject.AddComponent<GasMineBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_MINE_URANIUM, gameObject.AddComponent<UraniumMineBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_MINE_PEAT, gameObject.AddComponent<PeatMineBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_POWERPLANT_COAL, gameObject.AddComponent<CoalPowerPlantBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_POWERPLANT_SOLAR, gameObject.AddComponent<SolarPowerPlantBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_POWERPLANT_WIND, gameObject.AddComponent<WindPowerPlantBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_POWERPLANT_WATER, gameObject.AddComponent<WaterPowerPlantBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_POWERPLANT_NUCLEAR, gameObject.AddComponent<NuclearPowerPlantBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_POWERPLANT_BIOMASS, gameObject.AddComponent<BiomassPowerPlantBuilding>());
				Instance = this;
                InstantiateBuildings();
            }
        }

        private void InstantiateBuildings()
        {
            foreach (_BaseBuilding _Build in this.Buildings.Values)
            {
                BuildingInstance buildingInstance = BuildingPrefab.GetComponent<BuildingInstance>();
                buildingInstance.BuildingName.GetComponent<TMP_Text>().text = _Build.Name;
                buildingInstance.AmountText.GetComponent<TMP_Text>().text = _Build.Amount.ToString();
                buildingInstance.GenerateText.GetComponent<TMP_Text>().text = _Build.Production.ToString() + "/s";
                buildingInstance.iBuildAmount = _Build.Amount;
                buildingInstance.iBuildCost = _Build.Cost;

                GameObject _Building = PrefabUtility.InstantiatePrefab(BuildingPrefab) as GameObject;
                _Building.transform.SetParent(GameObject.Find("UI/Canvas/"+_Build.PanelName).transform, false);
                this.BuildingInstances.Add(_Build.Name, _Building);
            }
        }
    }
}
