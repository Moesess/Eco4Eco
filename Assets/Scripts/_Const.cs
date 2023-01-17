namespace EcoGame
{
    namespace Buildings
    {
        // Klucze do BuildingManager.Buildings
        public static class BuildingConsts{
            public static readonly string BUILDING_MINE_OIL                 = "mineOil";
            public static readonly string BUILDING_MINE_COAL                = "mineCoal";
            public static readonly string BUILDING_MINE_GAS                 = "mineGas";
            public static readonly string BUILDING_MINE_URANIUM             = "mineUranium";
            public static readonly string BUILDING_MINE_PEAT                = "minePeat";
            public static readonly string BUILDING_POWERPLANT_COAL          = "powerPlantCoal";
            public static readonly string BUILDING_POWERPLANT_SOLAR         = "powerPlantSolar";
            public static readonly string BUILDING_POWERPLANT_WIND          = "powerPlantWind";
            public static readonly string BUILDING_POWERPLANT_WATER         = "powerPlantWater";
            public static readonly string BUILDING_POWERPLANT_NUCLEAR       = "powerPlantNuclear";
            public static readonly string BUILDING_POWERPLANT_BIOMASS       = "powerPlantBiomass";
            public static readonly string BUILDING_FOOD_PROCESSEDFOOD       = "foodProcessedFood";
            public static readonly string BUILDING_FOOD_FISHING             = "foodFishing";
            public static readonly string BUILDING_FOOD_ANIMALFARM          = "foodAnimalFarm";
            public static readonly string BUILDING_FOOD_DRINKINGWATER       = "foodDrinkingWater";
            public static readonly string BUILDING_FOOD_EXPERIMENTALMEAT    = "foodExperimentalMeat";
            public static readonly string BUILDING_FOOD_FARMLAND            = "foodFarmland";
            public static readonly string BUILDING_TRASH_RECYCLING          = "trashRecycling";
            public static readonly string BUILDING_TRASH_GARBAGEINCINERATOR = "trashGarbageIncinerator";
            public static readonly string BUILDING_TRASH_GARBAGEDUMP        = "trashGarbageDump";
            public static readonly string BUILDING_TRASH_COMPOSTINGPLANT    = "trashCompostingPlant";
            public static readonly string BUILDING_TRASH_GARBAGESHIP        = "trashGarbageShip";
            public static readonly string BUILDING_GOODS_ELECTRONICSFACTORY = "goodsElectronicsFactory";
            public static readonly string BUILDING_GOODS_CLOTHESSEWING      = "goodsClothesSewing";
            public static readonly string BUILDING_GOODS_CARFACTORY         = "goodsCarFactory";
        }
    }
    namespace Resources
    {
        // Klucze do ResourceManager.Resources
        public static class ResourcesConsts
        {
            public static readonly string RESOURCE_COAL         = "resCoal";
            public static readonly string RESOURCE_GAS          = "resGas";
            public static readonly string RESOURCE_OIL          = "resOil";
            public static readonly string RESOURCE_URANIUM      = "resUranium";
            public static readonly string RESOURCE_PEAT         = "resPeat";
            public static readonly string RESOURCE_POWER        = "resPower";
            public static readonly string RESOURCE_BUDGET       = "resBudget";
            public static readonly string RESOURCE_TRASH        = "resTrash";
            public static readonly string RESOURCE_FOOD         = "resFood";
            public static readonly string RESOURCE_GOODS        = "resGoods";
            public static readonly string RESOURCE_POLLUTION    = "resPollution";
        }
    }
    namespace Json
    {
        public static class JsonConsts 
        {
            public static readonly string EVENT_FILE_NAME       = "events.json";
            public static readonly string SAVE_FILE_NAME        = "save.json";
        }
    }
}
