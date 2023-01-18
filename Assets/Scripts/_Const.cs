namespace EcoGame
{
    namespace Buildings
    {
        // Klucze do BuildingManager.Buildings
        public enum BUILDINGS
        {
            BUILDING_MINE_OIL = 0,
            BUILDING_MINE_COAL = 1,
            BUILDING_MINE_GAS = 2,
            BUILDING_MINE_URANIUM = 3, 
            BUILDING_MINE_PEAT = 4,
            BUILDING_POWERPLANT_COAL = 5,
            BUILDING_POWERPLANT_SOLAR = 6,
            BUILDING_POWERPLANT_WIND = 7,
            BUILDING_POWERPLANT_WATER = 8,
            BUILDING_POWERPLANT_NUCLEAR = 9,
            BUILDING_POWERPLANT_BIOMASS = 10,
            BUILDING_FOOD_PROCESSEDFOOD = 11,
            BUILDING_FOOD_FISHING = 12,
            BUILDING_FOOD_ANIMALFARM = 13,
            BUILDING_FOOD_DRINKINGWATER = 14,
            BUILDING_FOOD_EXPERIMENTALMEAT = 15,
            BUILDING_FOOD_FARMLAND = 16,
            BUILDING_TRASH_RECYCLING = 17,
            BUILDING_TRASH_GARBAGEINCINERATOR = 18,
            BUILDING_TRASH_GARBAGEDUMP = 19,
            BUILDING_TRASH_COMPOSTINGPLANT = 20,
            BUILDING_TRASH_GARBAGESHIP = 21,
            BUILDING_GOODS_ELECTRONICSFACTORY = 22,
            BUILDING_GOODS_CLOTHESSEWING = 23,
            BUILDING_GOODS_CARFACTORY = 24
        }
    }
    namespace Resources
    {
        // Klucze do ResourceManager.Resources
        public enum RESOURCES
        {
            RESOURCE_COAL = 0,
            RESOURCE_GAS = 1,
            RESOURCE_OIL = 2,
            RESOURCE_URANIUM = 3,
            RESOURCE_PEAT = 4,
            RESOURCE_POWER = 5,
            RESOURCE_BUDGET = 6,
            RESOURCE_TRASH = 7,
            RESOURCE_FOOD = 8,
            RESOURCE_GOODS = 9,
            RESOURCE_POLLUTION = 10,
            RESOURCE_LEAF = 11
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
