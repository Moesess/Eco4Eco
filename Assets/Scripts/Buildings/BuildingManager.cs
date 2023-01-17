using EcoGame;
using EcoGame.Buildings;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
                this.Buildings.Add(BuildingConsts.BUILDING_FOOD_PROCESSEDFOOD, gameObject.AddComponent<ProcessedFoodBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_FOOD_FISHING, gameObject.AddComponent<FishingBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_FOOD_ANIMALFARM, gameObject.AddComponent<AnimalFarmBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_FOOD_DRINKINGWATER, gameObject.AddComponent<DrinkingWaterBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_FOOD_EXPERIMENTALMEAT, gameObject.AddComponent<ExperimentalMeatBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_FOOD_FARMLAND, gameObject.AddComponent<FarmlandBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_TRASH_RECYCLING, gameObject.AddComponent<RecyclingBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_TRASH_GARBAGEINCINERATOR, gameObject.AddComponent<GarbageIncineratorBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_TRASH_GARBAGEDUMP, gameObject.AddComponent<GarbageDumpBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_TRASH_COMPOSTINGPLANT, gameObject.AddComponent<CompostingPlantBuilding>());
                this.Buildings.Add(BuildingConsts.BUILDING_TRASH_GARBAGESHIP, gameObject.AddComponent<GarbageShipBuilding>());
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
                buildingInstance.sBuildName = this.Buildings.FirstOrDefault(x => x.Value.Equals(_Build)).Key;

                GameObject _Building = PrefabUtility.InstantiatePrefab(BuildingPrefab) as GameObject;
                _Building.transform.SetParent(GameObject.Find("UI/Canvas/"+_Build.PanelName).transform, false);
                this.BuildingInstances.Add(_Build.Name, _Building);
            }
        }
    }
}
