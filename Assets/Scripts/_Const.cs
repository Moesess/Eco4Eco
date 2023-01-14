namespace EcoGame
{
    namespace Buildings
    {
        // Klucze do BuildingManager.Buildings
        public static class BuildingConsts{
            public static readonly string BUILDING_MINE_OIL     = "mineOil";
            public static readonly string BUILDING_MINE_COAL    = "mineCoal";
            public static readonly string BUILDING_MINE_GAS     = "mineGas";
            public static readonly string BUILDING_POWERPLANT   = "powerPlant";
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
