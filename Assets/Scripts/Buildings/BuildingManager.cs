using EcoGame.Buildings;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace EcoGame
{
    using static Buildings.BUILDINGS;
    public class BuildingManager : MonoBehaviour
    {
        [SerializeField] GameObject BuildingPrefab;

        public static BuildingManager Instance;
        public Dictionary<int, _BaseBuilding> Buildings = new();

        // NOT USED RN
        public Dictionary<string, GameObject> BuildingInstances = new();

        private void Awake()
        {
            if (Instance == null)
            {
                this.Buildings.Add((int)BUILDING_MINE_OIL, gameObject.AddComponent<OilMineBuilding>());
                this.Buildings.Add((int)BUILDING_MINE_COAL, gameObject.AddComponent<CoalMineBuilding>());
                this.Buildings.Add((int)BUILDING_MINE_GAS, gameObject.AddComponent<GasMineBuilding>());
                this.Buildings.Add((int)BUILDING_MINE_URANIUM, gameObject.AddComponent<UraniumMineBuilding>());
                this.Buildings.Add((int)BUILDING_MINE_PEAT, gameObject.AddComponent<PeatMineBuilding>());
                this.Buildings.Add((int)BUILDING_POWERPLANT_COAL, gameObject.AddComponent<CoalPowerPlantBuilding>());
                this.Buildings.Add((int)BUILDING_POWERPLANT_SOLAR, gameObject.AddComponent<SolarPowerPlantBuilding>());
                this.Buildings.Add((int)BUILDING_POWERPLANT_WIND, gameObject.AddComponent<WindPowerPlantBuilding>());
                this.Buildings.Add((int)BUILDING_POWERPLANT_WATER, gameObject.AddComponent<WaterPowerPlantBuilding>());
                this.Buildings.Add((int)BUILDING_POWERPLANT_NUCLEAR, gameObject.AddComponent<NuclearPowerPlantBuilding>());
                this.Buildings.Add((int)BUILDING_POWERPLANT_BIOMASS, gameObject.AddComponent<BiomassPowerPlantBuilding>());
                this.Buildings.Add((int)BUILDING_FOOD_PROCESSEDFOOD, gameObject.AddComponent<ProcessedFoodBuilding>());
                this.Buildings.Add((int)BUILDING_FOOD_FISHING, gameObject.AddComponent<FishingBuilding>());
                this.Buildings.Add((int)BUILDING_FOOD_ANIMALFARM, gameObject.AddComponent<AnimalFarmBuilding>());
                this.Buildings.Add((int)BUILDING_FOOD_DRINKINGWATER, gameObject.AddComponent<DrinkingWaterBuilding>());
                this.Buildings.Add((int)BUILDING_FOOD_EXPERIMENTALMEAT, gameObject.AddComponent<ExperimentalMeatBuilding>());
                this.Buildings.Add((int)BUILDING_FOOD_FARMLAND, gameObject.AddComponent<FarmlandBuilding>());
                this.Buildings.Add((int)BUILDING_TRASH_RECYCLING, gameObject.AddComponent<RecyclingBuilding>());
                this.Buildings.Add((int)BUILDING_TRASH_GARBAGEINCINERATOR, gameObject.AddComponent<GarbageIncineratorBuilding>());
                this.Buildings.Add((int)BUILDING_TRASH_GARBAGEDUMP, gameObject.AddComponent<GarbageDumpBuilding>());
                this.Buildings.Add((int)BUILDING_TRASH_COMPOSTINGPLANT, gameObject.AddComponent<CompostingPlantBuilding>());
                this.Buildings.Add((int)BUILDING_TRASH_GARBAGESHIP, gameObject.AddComponent<GarbageShipBuilding>());
                this.Buildings.Add((int)BUILDING_GOODS_CARFACTORY, gameObject.AddComponent<CarFactoryBuilding>());
                this.Buildings.Add((int)BUILDING_GOODS_ELECTRONICSFACTORY, gameObject.AddComponent<ElectronicsFactoryBuilding>());
                this.Buildings.Add((int)BUILDING_GOODS_CLOTHESSEWING, gameObject.AddComponent<ClothesSewingBuilding>());
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
                buildingInstance.iBuildKey= this.Buildings.FirstOrDefault(x => x.Value.Equals(_Build)).Key;

                GameObject _Building = PrefabUtility.InstantiatePrefab(BuildingPrefab) as GameObject;
                _Building.transform.SetParent(GameObject.Find("UI/Canvas/"+_Build.PanelName).transform, false);
                this.BuildingInstances.Add(_Build.Name, _Building);
            }
        }
    }
}
