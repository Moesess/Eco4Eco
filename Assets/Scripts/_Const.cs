using System.Collections.Generic;
using UnityEngine;

namespace EcoGame
{
    namespace Buildings
    {
        // Klucze do BuildingManager.Buildings
        public enum BUILDINGS
        {
            B_MINE_OIL                   = 0,
            B_MINE_COAL                  = 1,
            B_MINE_GAS                   = 2,
            B_MINE_URANIUM               = 3,
            B_MINE_PEAT                  = 4,
            B_POWERPLANT_COAL            = 5,
            B_POWERPLANT_SOLAR           = 6,
            B_POWERPLANT_WIND            = 7,
            B_POWERPLANT_WATER           = 8,
            B_POWERPLANT_NUCLEAR         = 9,
            B_POWERPLANT_BIOMASS         = 10,
            B_FOOD_PROCESSEDFOOD         = 11,
            B_FOOD_FISHING               = 12,
            B_FOOD_ANIMALFARM            = 13,
            B_FOOD_DRINKINGWATER         = 14,
            B_FOOD_EXPERIMENTALMEAT      = 15,
            B_FOOD_FARMLAND              = 16,
            B_TRASH_RECYCLING            = 17,
            B_TRASH_GARBAGEINCINERATOR   = 18,
            B_TRASH_GARBAGEDUMP          = 19,
            B_TRASH_COMPOSTINGPLANT      = 20,
            B_TRASH_GARBAGESHIP          = 21,
            B_GOODS_ELECTRONICSFACTORY   = 22,
            B_GOODS_CLOTHESSEWING        = 23,
            B_GOODS_CARFACTORY           = 24
        }

        // Koszta bazowe budynków
        public enum BUILDINGS_BASE_COSTS
        {
            B_COST_MINE_OIL                   = 100,
            B_COST_MINE_COAL                  = 100,
            B_COST_MINE_GAS                   = 100,
            B_COST_MINE_URANIUM               = 100,
            B_COST_MINE_PEAT                  = 100,
            B_COST_POWERPLANT_COAL            = 100,
            B_COST_POWERPLANT_SOLAR           = 100,
            B_COST_POWERPLANT_WIND            = 100,
            B_COST_POWERPLANT_WATER           = 100,
            B_COST_POWERPLANT_NUCLEAR         = 100,
            B_COST_POWERPLANT_BIOMASS         = 100,
            B_COST_FOOD_PROCESSEDFOOD         = 100,
            B_COST_FOOD_FISHING               = 100,
            B_COST_FOOD_ANIMALFARM            = 100,
            B_COST_FOOD_DRINKINGWATER         = 100,
            B_COST_FOOD_EXPERIMENTALMEAT      = 100,
            B_COST_FOOD_FARMLAND              = 100,
            B_COST_TRASH_RECYCLING            = 100,
            B_COST_TRASH_GARBAGEINCINERATOR   = 100,
            B_COST_TRASH_GARBAGEDUMP          = 100,
            B_COST_TRASH_COMPOSTINGPLANT      = 100,
            B_COST_TRASH_GARBAGESHIP          = 100,
            B_COST_GOODS_ELECTRONICSFACTORY   = 100,
            B_COST_GOODS_CLOTHESSEWING        = 100,
            B_COST_GOODS_CARFACTORY           = 100,
        }

        // Poziomy technologiczne budynków
        public enum BUILDINGS_TECH_LEVEL
        {
            B_TECH_MINE_OIL                   = 1,
            B_TECH_MINE_COAL                  = 1,
            B_TECH_MINE_GAS                   = 1,
            B_TECH_MINE_URANIUM               = 1,
            B_TECH_MINE_PEAT                  = 1,
            B_TECH_POWERPLANT_COAL            = 1,
            B_TECH_POWERPLANT_SOLAR           = 1,
            B_TECH_POWERPLANT_WIND            = 1,
            B_TECH_POWERPLANT_WATER           = 1,
            B_TECH_POWERPLANT_NUCLEAR         = 1,
            B_TECH_POWERPLANT_BIOMASS         = 1,
            B_TECH_FOOD_PROCESSEDFOOD         = 1,
            B_TECH_FOOD_FISHING               = 1,
            B_TECH_FOOD_ANIMALFARM            = 1,
            B_TECH_FOOD_DRINKINGWATER         = 1,
            B_TECH_FOOD_EXPERIMENTALMEAT      = 1,
            B_TECH_FOOD_FARMLAND              = 1,
            B_TECH_TRASH_RECYCLING            = 1,
            B_TECH_TRASH_GARBAGEINCINERATOR   = 1,
            B_TECH_TRASH_GARBAGEDUMP          = 1,
            B_TECH_TRASH_COMPOSTINGPLANT      = 1,
            B_TECH_TRASH_GARBAGESHIP          = 1,
            B_TECH_GOODS_ELECTRONICSFACTORY   = 1,
            B_TECH_GOODS_CLOTHESSEWING        = 1,
            B_TECH_GOODS_CARFACTORY           = 1,
        }
        // Bazowa produkcja budynkow
        public enum BUILDINGS_BASE_PRODUCTION
        {
            B_PROD_MINE_OIL                   = 1,
            B_PROD_MINE_COAL                  = 1,
            B_PROD_MINE_GAS                   = 1,
            B_PROD_MINE_URANIUM               = 1,
            B_PROD_MINE_PEAT                  = 1,
            B_PROD_POWERPLANT_COAL            = 1,
            B_PROD_POWERPLANT_SOLAR           = 1,
            B_PROD_POWERPLANT_WIND            = 1,
            B_PROD_POWERPLANT_WATER           = 1,
            B_PROD_POWERPLANT_NUCLEAR         = 1,
            B_PROD_POWERPLANT_BIOMASS         = 1,
            B_PROD_FOOD_PROCESSEDFOOD         = 1,
            B_PROD_FOOD_FISHING               = 1,
            B_PROD_FOOD_ANIMALFARM            = 1,
            B_PROD_FOOD_DRINKINGWATER         = 1,
            B_PROD_FOOD_EXPERIMENTALMEAT      = 1,
            B_PROD_FOOD_FARMLAND              = 1,
            B_PROD_TRASH_RECYCLING            = 1,
            B_PROD_TRASH_GARBAGEINCINERATOR   = 1,
            B_PROD_TRASH_GARBAGEDUMP          = 1,
            B_PROD_TRASH_COMPOSTINGPLANT      = 1,
            B_PROD_TRASH_GARBAGESHIP          = 1,
            B_PROD_GOODS_ELECTRONICSFACTORY   = 1,
            B_PROD_GOODS_CLOTHESSEWING        = 1,
            B_PROD_GOODS_CARFACTORY           = 1,
        }
        // Bazowe zanieczyszczenia budynkow
        public enum BUILDINGS_BASE_POLLUTION
        {
            B_POLLUTION_MINE_OIL                   = 1,
            B_POLLUTION_MINE_COAL                  = 1,
            B_POLLUTION_MINE_GAS                   = 1,
            B_POLLUTION_MINE_URANIUM               = 1,
            B_POLLUTION_MINE_PEAT                  = 1,
            B_POLLUTION_POWERPLANT_COAL            = 1,
            B_POLLUTION_POWERPLANT_SOLAR           = 1,
            B_POLLUTION_POWERPLANT_WIND            = 1,
            B_POLLUTION_POWERPLANT_WATER           = 1,
            B_POLLUTION_POWERPLANT_NUCLEAR         = 1,
            B_POLLUTION_POWERPLANT_BIOMASS         = 1,
            B_POLLUTION_FOOD_PROCESSEDFOOD         = 1,
            B_POLLUTION_FOOD_FISHING               = 1,
            B_POLLUTION_FOOD_ANIMALFARM            = 1,
            B_POLLUTION_FOOD_DRINKINGWATER         = 1,
            B_POLLUTION_FOOD_EXPERIMENTALMEAT      = 1,
            B_POLLUTION_FOOD_FARMLAND              = 1,
            B_POLLUTION_TRASH_RECYCLING            = 1,
            B_POLLUTION_TRASH_GARBAGEINCINERATOR   = 1,
            B_POLLUTION_TRASH_GARBAGEDUMP          = 1,
            B_POLLUTION_TRASH_COMPOSTINGPLANT      = 1,
            B_POLLUTION_TRASH_GARBAGESHIP          = 1,
            B_POLLUTION_GOODS_ELECTRONICSFACTORY   = 1,
            B_POLLUTION_GOODS_CLOTHESSEWING        = 1,
            B_POLLUTION_GOODS_CARFACTORY           = 1,
        }
        // Bazowe uzycie surowcow przez budynek
        public enum BUILDINGS_USED_RESOURCE_AMOUNTS
        {
            B_USED_RES_AMOUNT_MINE_OIL                   = 1,
            B_USED_RES_AMOUNT_MINE_COAL                  = 1,
            B_USED_RES_AMOUNT_MINE_GAS                   = 1,
            B_USED_RES_AMOUNT_MINE_URANIUM               = 1,
            B_USED_RES_AMOUNT_MINE_PEAT                  = 1,
            B_USED_RES_AMOUNT_POWERPLANT_COAL            = 1,
            B_USED_RES_AMOUNT_POWERPLANT_SOLAR           = 1,
            B_USED_RES_AMOUNT_POWERPLANT_WIND            = 1,
            B_USED_RES_AMOUNT_POWERPLANT_WATER           = 1,
            B_USED_RES_AMOUNT_POWERPLANT_NUCLEAR         = 1,
            B_USED_RES_AMOUNT_POWERPLANT_BIOMASS         = 1,
            B_USED_RES_AMOUNT_FOOD_PROCESSEDFOOD         = 1,
            B_USED_RES_AMOUNT_FOOD_FISHING               = 1,
            B_USED_RES_AMOUNT_FOOD_ANIMALFARM            = 1,
            B_USED_RES_AMOUNT_FOOD_DRINKINGWATER         = 1,
            B_USED_RES_AMOUNT_FOOD_EXPERIMENTALMEAT      = 1,
            B_USED_RES_AMOUNT_FOOD_FARMLAND              = 1,
            B_USED_RES_AMOUNT_TRASH_RECYCLING            = 1,
            B_USED_RES_AMOUNT_TRASH_GARBAGEINCINERATOR   = 1,
            B_USED_RES_AMOUNT_TRASH_GARBAGEDUMP          = 1,
            B_USED_RES_AMOUNT_TRASH_COMPOSTINGPLANT      = 1,
            B_USED_RES_AMOUNT_TRASH_GARBAGESHIP          = 1,
            B_USED_RES_AMOUNT_GOODS_ELECTRONICSFACTORY   = 1,
            B_USED_RES_AMOUNT_GOODS_CLOTHESSEWING        = 1,
            B_USED_RES_AMOUNT_GOODS_CARFACTORY           = 1,
        }

        // Do ustalenia jakie mno¿niki DEFAULTOWE bêdziemy mieæ
        public enum BUILDINGS_MULTIPLIERS
        {
            B_MULT_COST_MINE_OIL                 = 1,
            B_MULT_COST_MINE_COAL                = 1,
            B_MULT_COST_MINE_GAS                 = 1,
            B_MULT_COST_MINE_URANIUM             = 1,
            B_MULT_COST_MINE_PEAT                = 1,
            B_MULT_COST_POWERPLANT_COAL          = 1,
            B_MULT_COST_POWERPLANT_SOLAR         = 1,
            B_MULT_COST_POWERPLANT_WIND          = 1,
            B_MULT_COST_POWERPLANT_WATER         = 1,
            B_MULT_COST_POWERPLANT_NUCLEAR       = 1,
            B_MULT_COST_POWERPLANT_BIOMASS       = 1,
            B_MULT_COST_FOOD_PROCESSEDFOOD       = 1,
            B_MULT_COST_FOOD_FISHING             = 1,
            B_MULT_COST_FOOD_ANIMALFARM          = 1,
            B_MULT_COST_FOOD_DRINKINGWATER       = 1,
            B_MULT_COST_FOOD_EXPERIMENTALMEAT    = 1,
            B_MULT_COST_FOOD_FARMLAND            = 1,
            B_MULT_COST_TRASH_RECYCLING          = 1,
            B_MULT_COST_TRASH_GARBAGEINCINERATOR = 1,
            B_MULT_COST_TRASH_GARBAGEDUMP        = 1,
            B_MULT_COST_TRASH_COMPOSTINGPLANT    = 1,
            B_MULT_COST_TRASH_GARBAGESHIP        = 1,
            B_MULT_COST_GOODS_ELECTRONICSFACTORY = 1,
            B_MULT_COST_GOODS_CLOTHESSEWING      = 1,
            B_MULT_COST_GOODS_CARFACTORY         = 1,

            B_MULT_PROD_MINE_OIL                 = 1,
            B_MULT_PROD_MINE_COAL                = 1,
            B_MULT_PROD_MINE_GAS                 = 1,
            B_MULT_PROD_MINE_URANIUM             = 1,
            B_MULT_PROD_MINE_PEAT                = 1,
            B_MULT_PROD_POWERPLANT_COAL          = 1,
            B_MULT_PROD_POWERPLANT_SOLAR         = 1,
            B_MULT_PROD_POWERPLANT_WIND          = 1,
            B_MULT_PROD_POWERPLANT_WATER         = 1,
            B_MULT_PROD_POWERPLANT_NUCLEAR       = 1,
            B_MULT_PROD_POWERPLANT_BIOMASS       = 1,
            B_MULT_PROD_FOOD_PROCESSEDFOOD       = 1,
            B_MULT_PROD_FOOD_FISHING             = 1,
            B_MULT_PROD_FOOD_ANIMALFARM          = 1,
            B_MULT_PROD_FOOD_DRINKINGWATER       = 1,
            B_MULT_PROD_FOOD_EXPERIMENTALMEAT    = 1,
            B_MULT_PROD_FOOD_FARMLAND            = 1,
            B_MULT_PROD_TRASH_RECYCLING          = 1,
            B_MULT_PROD_TRASH_GARBAGEINCINERATOR = 1,
            B_MULT_PROD_TRASH_GARBAGEDUMP        = 1,
            B_MULT_PROD_TRASH_COMPOSTINGPLANT    = 1,
            B_MULT_PROD_TRASH_GARBAGESHIP        = 1,
            B_MULT_PROD_GOODS_ELECTRONICSFACTORY = 1,
            B_MULT_PROD_GOODS_CLOTHESSEWING      = 1,
            B_MULT_PROD_GOODS_CARFACTORY         = 1,
        }
    }
    namespace Resources
    {
        // Klucze do ResourceManager.Resources
        public enum RESOURCES
        {
	        R_NULL              = 99,
            R_COAL              = 0,
            R_GAS               = 1,
            R_OIL               = 2,
            R_URANIUM           = 3,
            R_PEAT              = 4,
            R_POWER             = 5,
            R_BUDGET            = 6,
            R_TRASH             = 7,
            R_FOOD              = 8,
            R_GOODS             = 9,
            R_POLLUTION         = 10,
            R_LEAF              = 11,
            R_HAPPY             = 12,
            R_POLLUTION_MAXIMUM = 10000,
        }
    }
    
    // Kolory dla wyswietlania zadowolenia
    public static class Colors
    {
        public static Color Good = new(0.1529412f, 0.682353f, 0.3764706f);
        public static Color Bad = new(0.9058824f, 0.2980392f, 0.2352941f);
        public static Color Medium = new(0.9529412f, 0.6117647f, 0.07058824f);
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
