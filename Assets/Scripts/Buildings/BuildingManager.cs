using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace EcoGame
{
    using static Buildings.BUILDINGS;
    using static Buildings.BUILDINGS_MULTIPLIERS;
    using static Buildings.BUILDINGS_BASE_COSTS;
    using static Buildings.BUILDINGS_TECH_LEVEL;
    using static Buildings.BUILDINGS_BASE_PRODUCTION;
    using static Buildings.BUILDINGS_BASE_POLLUTION;
    using static Buildings.BUILDINGS_USED_RESOURCE_AMOUNTS;
    using static Buildings.BUILDINGS_DESCRIPTIONS;
    using static Resources.RESOURCES;

    public class BuildingManager : MonoBehaviour
    {
        [SerializeField] GameObject BuildingPrefab;

        public static BuildingManager Instance;
        public Dictionary<int, _BaseBuilding> Buildings = new();

        //// NOT USED RN
        //public Dictionary<string, GameObject> BuildingInstances = new();

        private void Start()
        {
            Recalculate();
        }

        private void Awake()
        {
            if (Instance == null)
            {
                // ==================== KOPALNIE ====================
                this.Buildings.Add( (int)B_MINE_OIL, // Klucz budynku
                    new _BaseBuilding(
                        "Kopalnia ropy naftowej",   // Nazwa Budynku
                        "Mine Panel",               // Panel na ktorym budynek sie pojawia
                        R_OIL,                 // Surowiec jaki produkuje
                        R_POWER,               // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_MINE_OIL, // Ile Surowca wykorzystuje
                        (int)B_COST_MINE_OIL,       // Koszt podstawowy
                        (int)B_COST_MINE_OIL,       // Koszt aktualny
                        (int)B_TECH_MINE_OIL,       // Poziom technologii
                        0,                          // Ilosc budynkow
                        (int)B_PROD_MINE_OIL,       // Bazowa produkcja
                        (int)B_POLLUTION_MINE_OIL,  // Generowane zanieczyszczenie
                        (int)B_MULT_COST_MINE_OIL,  // Mnoznik kosztow
                        (int)B_MULT_PROD_MINE_OIL,   // Mnoznik produkcji,
                        B_DESC_MINE_OIL //Opis
                    )
                );

                this.Buildings.Add((int)B_MINE_COAL, // Klucz budynku
                    new _BaseBuilding(
                        "Kopalnia wêgla",           // Nazwa Budynku
                        "Mine Panel",               // Panel na ktorym budynek sie pojawia
                        R_COAL,                // Surowiec jaki produkuje
                        R_POWER,               // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_MINE_COAL, // Ile Surowca wykorzystuje
                        (int)B_COST_MINE_COAL,      // Koszt podstawowy
                        (int)B_COST_MINE_COAL,      // Koszt aktualny
                        (int)B_TECH_MINE_COAL,      // Poziom technologii
                        0,                          // Ilosc budynkow
                        (int)B_PROD_MINE_COAL,      // Bazowa produkcja
                        (int)B_POLLUTION_MINE_COAL, // Generowane zanieczyszczenie
                        (int)B_MULT_COST_MINE_COAL, // Mnoznik kosztow
                        (int)B_MULT_PROD_MINE_COAL,  // Mnoznik produkcji
                        B_DESC_MINE_COAL //Opis
					)
                );

                this.Buildings.Add((int)B_MINE_GAS, // Klucz budynku
                    new _BaseBuilding(
                        "Kopalnia gazu",            // Nazwa Budynku
                        "Mine Panel",               // Panel na ktorym budynek sie pojawia
                        R_GAS,                 // Surowiec jaki produkuje
                        R_POWER,               // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_MINE_GAS, // Ile Surowca wykorzystuje
                        (int)B_COST_MINE_GAS,       // Koszt podstawowy
                        (int)B_COST_MINE_GAS,       // Koszt aktualny
                        (int)B_TECH_MINE_GAS,       // Poziom technologii
                        0,                          // Ilosc budynkow
                        (int)B_PROD_MINE_GAS,       // Bazowa produkcja
                        (int)B_POLLUTION_MINE_GAS,  // Generowane zanieczyszczenie
                        (int)B_MULT_COST_MINE_GAS,  // Mnoznik kosztow
                        (int)B_MULT_PROD_MINE_GAS,   // Mnoznik produkcji
                        B_DESC_MINE_GAS //Opis
					)
                );

                this.Buildings.Add((int)B_MINE_PEAT, // Klucz budynku
                    new _BaseBuilding(
                        "Kopalnia torfu",           // Nazwa Budynku
                        "Mine Panel",               // Panel na ktorym budynek sie pojawia
                        R_PEAT,                // Surowiec jaki produkuje
                        R_POWER,               // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_MINE_PEAT, // Ile Surowca wykorzystuje
                        (int)B_COST_MINE_PEAT,      // Koszt podstawowy
                        (int)B_COST_MINE_PEAT,      // Koszt aktualny
                        (int)B_TECH_MINE_PEAT,      // Poziom technologii
                        0,                          // Ilosc budynkow
                        (int)B_PROD_MINE_PEAT,      // Bazowa produkcja
                        (int)B_POLLUTION_MINE_PEAT, // Generowane zanieczyszczenie
                        (int)B_MULT_COST_MINE_PEAT, // Mnoznik kosztow
                        (int)B_MULT_PROD_MINE_PEAT,  // Mnoznik produkcji
                        B_DESC_MINE_PEAT //Opis
					)
                );

                this.Buildings.Add((int)B_MINE_URANIUM, // Klucz budynku
                    new _BaseBuilding(
                        "Kopalnia uranu",               // Nazwa Budynku
                        "Mine Panel",                   // Panel na ktorym budynek sie pojawia
                        R_URANIUM,                 // Surowiec jaki produkuje
                        R_POWER,                   // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_MINE_URANIUM, // Ile Surowca wykorzystuje
                        (int)B_COST_MINE_URANIUM,       // Koszt podstawowy
                        (int)B_COST_MINE_URANIUM,       // Koszt aktualny
                        (int)B_TECH_MINE_URANIUM,       // Poziom technologii
                        0,                              // Ilosc budynkow
                        (int)B_PROD_MINE_URANIUM,       // Bazowa produkcja
                        (int)B_POLLUTION_MINE_URANIUM,  // Generowane zanieczyszczenie
                        (int)B_MULT_COST_MINE_URANIUM,  // Mnoznik kosztow
                        (int)B_MULT_PROD_MINE_URANIUM,   // Mnoznik produkcji
                        B_DESC_MINE_URANIUM //Opis
					)
                );

                // ==================== DOBRA KONSUMPCYJNE ====================

                this.Buildings.Add((int)B_GOODS_CARFACTORY, // Klucz budynku
                    new _BaseBuilding(
                        "Fabryka samochodów",               // Nazwa Budynku
                        "Goods Panel",                      // Panel na ktorym budynek sie pojawia
                        R_GOODS,                       // Surowiec jaki produkuje
                        R_POWER,                       // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_GOODS_CARFACTORY,    // Ile Surowca wykorzystuje
                        (int)B_COST_GOODS_CARFACTORY,       // Koszt podstawowy
                        (int)B_COST_GOODS_CARFACTORY,       // Koszt aktualny
                        (int)B_TECH_GOODS_CARFACTORY,       // Poziom technologii
                        0,                                  // Ilosc budynkow
                        (int)B_PROD_GOODS_CARFACTORY,       // Bazowa produkcja
                        (int)B_POLLUTION_GOODS_CARFACTORY,  // Generowane zanieczyszczenie
                        (int)B_MULT_COST_GOODS_CARFACTORY,  // Mnoznik kosztow
                        (int)B_MULT_PROD_GOODS_CARFACTORY,   // Mnoznik produkcji
                        B_DESC_GOODS_CARFACTORY //Opis
					)
                );

                this.Buildings.Add((int)B_GOODS_CLOTHESSEWING, // Klucz budynku
                    new _BaseBuilding(
                        "Szwalnia ubrañ",                       // Nazwa Budynku
                        "Goods Panel",                          // Panel na ktorym budynek sie pojawia
                        R_GOODS,                           // Surowiec jaki produkuje
                        R_POWER,                           // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_GOODS_CLOTHESSEWING,        // Ile Surowca wykorzystuje
                        (int)B_COST_GOODS_CLOTHESSEWING,        // Koszt podstawowy
                        (int)B_COST_GOODS_CLOTHESSEWING,        // Koszt aktualny
                        (int)B_TECH_GOODS_CLOTHESSEWING,        // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_GOODS_CLOTHESSEWING,        // Bazowa produkcja
                        (int)B_POLLUTION_GOODS_CLOTHESSEWING,   // Generowane zanieczyszczenie
                        (int)B_MULT_COST_GOODS_CLOTHESSEWING,   // Mnoznik kosztow
                        (int)B_MULT_PROD_GOODS_CLOTHESSEWING,    // Mnoznik produkcji
                        B_DESC_GOODS_CLOTHESSEWING //Opis
					)
                );

                this.Buildings.Add((int)B_GOODS_ELECTRONICSFACTORY, // Klucz budynku
                    new _BaseBuilding(
                        "Fabryka elektroniki",                      // Nazwa Budynku
                        "Goods Panel",                              // Panel na ktorym budynek sie pojawia
                        R_GOODS,                               // Surowiec jaki produkuje
                        R_POWER,                               // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_GOODS_ELECTRONICSFACTORY,            // Ile Surowca wykorzystuje
                        (int)B_COST_GOODS_ELECTRONICSFACTORY,       // Koszt podstawowy
                        (int)B_COST_GOODS_ELECTRONICSFACTORY,       // Koszt aktualny
                        (int)B_TECH_GOODS_ELECTRONICSFACTORY,       // Poziom technologii
                        0,                                          // Ilosc budynkow
                        (int)B_PROD_GOODS_ELECTRONICSFACTORY,       // Bazowa produkcja
                        (int)B_POLLUTION_GOODS_ELECTRONICSFACTORY,  // Generowane zanieczyszczenie
                        (int)B_MULT_COST_GOODS_ELECTRONICSFACTORY,  // Mnoznik kosztow
                        (int)B_MULT_PROD_GOODS_ELECTRONICSFACTORY,   // Mnoznik produkcji
                        B_DESC_GOODS_ELECTRONICSFACTORY //Opis
					)
                );

                // ==================== JEDZENIE ====================

                this.Buildings.Add((int)B_FOOD_ANIMALFARM, // Klucz budynku
                    new _BaseBuilding(
                        "Hodowla zwierz¹t",                 // Nazwa Budynku
                        "Food Panel",                       // Panel na ktorym budynek sie pojawia
                        R_FOOD,                       // Surowiec jaki produkuje
                        R_POWER,                       // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_FOOD_ANIMALFARM,    // Ile Surowca wykorzystuje
                        (int)B_COST_FOOD_ANIMALFARM,        // Koszt podstawowy
                        (int)B_COST_FOOD_ANIMALFARM,        // Koszt aktualny
                        (int)B_TECH_FOOD_ANIMALFARM,        // Poziom technologii
                        0,                                  // Ilosc budynkow
                        (int)B_PROD_FOOD_ANIMALFARM,        // Bazowa produkcja
                        (int)B_POLLUTION_FOOD_ANIMALFARM,   // Generowane zanieczyszczenie
                        (int)B_MULT_COST_FOOD_ANIMALFARM,   // Mnoznik kosztow
                        (int)B_MULT_PROD_FOOD_ANIMALFARM,    // Mnoznik produkcji
                        B_DESC_FOOD_ANIMALFARM //Opis
					)
                );

                this.Buildings.Add((int)B_FOOD_DRINKINGWATER, // Klucz budynku
                    new _BaseBuilding(
                        "Punkt uzdatniania wody",                 // Nazwa Budynku
                        "Food Panel",                       // Panel na ktorym budynek sie pojawia
                        R_FOOD,                       // Surowiec jaki produkuje
                        R_POWER,                       // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_FOOD_DRINKINGWATER,    // Ile Surowca wykorzystuje
                        (int)B_COST_FOOD_DRINKINGWATER,        // Koszt podstawowy
                        (int)B_COST_FOOD_DRINKINGWATER,        // Koszt aktualny
                        (int)B_TECH_FOOD_DRINKINGWATER,        // Poziom technologii
                        0,                                  // Ilosc budynkow
                        (int)B_PROD_FOOD_DRINKINGWATER,        // Bazowa produkcja
                        (int)B_POLLUTION_FOOD_DRINKINGWATER,   // Generowane zanieczyszczenie
                        (int)B_MULT_COST_FOOD_DRINKINGWATER,   // Mnoznik kosztow
                        (int)B_MULT_PROD_FOOD_DRINKINGWATER,    // Mnoznik produkcji
                        B_DESC_FOOD_DRINKINGWATER //Opis
					)
                );


                this.Buildings.Add((int)B_FOOD_EXPERIMENTALMEAT, // Klucz budynku
                    new _BaseBuilding(
                        "Laboratorium miêsa z probówki",                 // Nazwa Budynku
                        "Food Panel",                       // Panel na ktorym budynek sie pojawia
                        R_FOOD,                       // Surowiec jaki produkuje
                        R_POWER,                       // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_FOOD_EXPERIMENTALMEAT,    // Ile Surowca wykorzystuje
                        (int)B_COST_FOOD_EXPERIMENTALMEAT,        // Koszt podstawowy
                        (int)B_COST_FOOD_EXPERIMENTALMEAT,        // Koszt aktualny
                        (int)B_TECH_FOOD_EXPERIMENTALMEAT,        // Poziom technologii
                        0,                                  // Ilosc budynkow
                        (int)B_PROD_FOOD_EXPERIMENTALMEAT,        // Bazowa produkcja
                        (int)B_POLLUTION_FOOD_EXPERIMENTALMEAT,   // Generowane zanieczyszczenie
                        (int)B_MULT_COST_FOOD_EXPERIMENTALMEAT,   // Mnoznik kosztow
                        (int)B_MULT_PROD_FOOD_EXPERIMENTALMEAT,    // Mnoznik produkcji
                        B_DESC_FOOD_EXPERIMENTALMEAT //Opis
					)
                );

                this.Buildings.Add((int)B_FOOD_FARMLAND, // Klucz budynku
                    new _BaseBuilding(
                        "Pole uprawne",                 // Nazwa Budynku
                        "Food Panel",                       // Panel na ktorym budynek sie pojawia
                        R_FOOD,                       // Surowiec jaki produkuje
                        R_POWER,                       // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_FOOD_FARMLAND,    // Ile Surowca wykorzystuje
                        (int)B_COST_FOOD_FARMLAND,        // Koszt podstawowy
                        (int)B_COST_FOOD_FARMLAND,        // Koszt aktualny
                        (int)B_TECH_FOOD_FARMLAND,        // Poziom technologii
                        0,                                  // Ilosc budynkow
                        (int)B_PROD_FOOD_FARMLAND,        // Bazowa produkcja
                        (int)B_POLLUTION_FOOD_FARMLAND,   // Generowane zanieczyszczenie
                        (int)B_MULT_COST_FOOD_FARMLAND,   // Mnoznik kosztow
                        (int)B_MULT_PROD_FOOD_FARMLAND,    // Mnoznik produkcji
                        B_DESC_FOOD_FARMLAND //Opis
					)
                );

                this.Buildings.Add((int)B_FOOD_FISHING, // Klucz budynku
                    new _BaseBuilding(
                        "Miejsca po³owu ryb",                 // Nazwa Budynku
                        "Food Panel",                       // Panel na ktorym budynek sie pojawia
                        R_FOOD,                       // Surowiec jaki produkuje
                        R_POWER,                       // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_FOOD_FISHING,    // Ile Surowca wykorzystuje
                        (int)B_COST_FOOD_FISHING,        // Koszt podstawowy
                        (int)B_COST_FOOD_FISHING,        // Koszt aktualny
                        (int)B_TECH_FOOD_FISHING,        // Poziom technologii
                        0,                                  // Ilosc budynkow
                        (int)B_PROD_FOOD_FISHING,        // Bazowa produkcja
                        (int)B_POLLUTION_FOOD_FISHING,   // Generowane zanieczyszczenie
                        (int)B_MULT_COST_FOOD_FISHING,   // Mnoznik kosztow
                        (int)B_MULT_PROD_FOOD_FISHING,    // Mnoznik produkcji
                        B_DESC_FOOD_FISHING //Opis
					)
                );

                this.Buildings.Add((int)B_FOOD_PROCESSEDFOOD, // Klucz budynku
                    new _BaseBuilding(
                        "¯ywnoœæ przetworzona",                 // Nazwa Budynku
                        "Food Panel",                           // Panel na ktorym budynek sie pojawia
                        R_FOOD,                            // Surowiec jaki produkuje
                        R_POWER,                           // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_FOOD_PROCESSEDFOOD, // Ile Surowca wykorzystuje
                        (int)B_COST_FOOD_PROCESSEDFOOD,        // Koszt podstawowy
                        (int)B_COST_FOOD_PROCESSEDFOOD,        // Koszt aktualny
                        (int)B_TECH_FOOD_PROCESSEDFOOD,        // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_FOOD_PROCESSEDFOOD,        // Bazowa produkcja
                        (int)B_POLLUTION_FOOD_PROCESSEDFOOD,   // Generowane zanieczyszczenie
                        (int)B_MULT_COST_FOOD_PROCESSEDFOOD,   // Mnoznik kosztow
                        (int)B_MULT_PROD_FOOD_PROCESSEDFOOD,    // Mnoznik produkcji
                        B_DESC_FOOD_PROCESSEDFOOD //Opis
					)
                );

                //==================== ELEKTROWNIE ====================

                this.Buildings.Add((int)B_POWERPLANT_BIOMASS, // Klucz budynku
                    new _BaseBuilding(
                        "Elektrownia na biomasê",               // Nazwa Budynku
                        "Power Panel",                          // Panel na ktorym budynek sie pojawia
                        R_POWER,                           // Surowiec jaki produkuje
                        R_PEAT,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_POWERPLANT_BIOMASS, // Ile Surowca wykorzystuje
                        (int)B_COST_POWERPLANT_BIOMASS,         // Koszt podstawowy
                        (int)B_COST_POWERPLANT_BIOMASS,         // Koszt aktualny
                        (int)B_TECH_POWERPLANT_BIOMASS,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_POWERPLANT_BIOMASS,         // Bazowa produkcja
                        (int)B_POLLUTION_POWERPLANT_BIOMASS,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_POWERPLANT_BIOMASS,    // Mnoznik kosztow
                        (int)B_MULT_PROD_POWERPLANT_BIOMASS,     // Mnoznik produkcji
                        B_DESC_POWERPLANT_BIOMASS //Opis
					)
                );

                this.Buildings.Add((int)B_POWERPLANT_COAL, // Klucz budynku
                    new _BaseBuilding(
                        "Elektrownia wêglowa",               // Nazwa Budynku
                        "Power Panel",                          // Panel na ktorym budynek sie pojawia
                        R_POWER,                           // Surowiec jaki produkuje
                        R_COAL,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_POWERPLANT_COAL, // Ile Surowca wykorzystuje
                        (int)B_COST_POWERPLANT_COAL,         // Koszt podstawowy
                        (int)B_COST_POWERPLANT_COAL,         // Koszt aktualny
                        (int)B_TECH_POWERPLANT_COAL,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_POWERPLANT_COAL,         // Bazowa produkcja
                        (int)B_POLLUTION_POWERPLANT_COAL,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_POWERPLANT_COAL,    // Mnoznik kosztow
                        (int)B_MULT_PROD_POWERPLANT_COAL,     // Mnoznik produkcji
                        B_DESC_POWERPLANT_COAL //Opis
					)
                );

                this.Buildings.Add((int)B_POWERPLANT_NUCLEAR, // Klucz budynku
                    new _BaseBuilding(
                        "Elektrownia atomowa",               // Nazwa Budynku
                        "Power Panel",                          // Panel na ktorym budynek sie pojawia
                        R_POWER,                           // Surowiec jaki produkuje
                        R_URANIUM,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_POWERPLANT_NUCLEAR, // Ile Surowca wykorzystuje
                        (int)B_COST_POWERPLANT_NUCLEAR,         // Koszt podstawowy
                        (int)B_COST_POWERPLANT_NUCLEAR,         // Koszt aktualny
                        (int)B_TECH_POWERPLANT_NUCLEAR,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_POWERPLANT_NUCLEAR,         // Bazowa produkcja
                        (int)B_POLLUTION_POWERPLANT_NUCLEAR,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_POWERPLANT_NUCLEAR,    // Mnoznik kosztow
                        (int)B_MULT_PROD_POWERPLANT_NUCLEAR,     // Mnoznik produkcji
                        B_DESC_POWERPLANT_NUCLEAR //Opis
					)
                );

                this.Buildings.Add((int)B_POWERPLANT_SOLAR, // Klucz budynku
                    new _BaseBuilding(
                        "Elektrownia solarna",               // Nazwa Budynku
                        "Power Panel",                          // Panel na ktorym budynek sie pojawia
                        R_POWER,                           // Surowiec jaki produkuje
                        R_NULL,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_POWERPLANT_SOLAR, // Ile Surowca wykorzystuje
                        (int)B_COST_POWERPLANT_SOLAR,         // Koszt podstawowy
                        (int)B_COST_POWERPLANT_SOLAR,         // Koszt aktualny
                        (int)B_TECH_POWERPLANT_SOLAR,         // Poziom technologii
                        1,                                      // Ilosc budynkow
                        (int)B_PROD_POWERPLANT_SOLAR,         // Bazowa produkcja
                        (int)B_POLLUTION_POWERPLANT_SOLAR,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_POWERPLANT_SOLAR,    // Mnoznik kosztow
                        (int)B_MULT_PROD_POWERPLANT_SOLAR,     // Mnoznik produkcji
                        B_DESC_POWERPLANT_SOLAR //Opis
					)
                );

                this.Buildings.Add((int)B_POWERPLANT_WATER, // Klucz budynku
                    new _BaseBuilding(
                        "Elektrownia wodna",               // Nazwa Budynku
                        "Power Panel",                          // Panel na ktorym budynek sie pojawia
                        R_POWER,                           // Surowiec jaki produkuje
                        R_NULL,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_POWERPLANT_WATER, // Ile Surowca wykorzystuje
                        (int)B_COST_POWERPLANT_WATER,         // Koszt podstawowy
                        (int)B_COST_POWERPLANT_WATER,         // Koszt aktualny
                        (int)B_TECH_POWERPLANT_WATER,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_POWERPLANT_WATER,         // Bazowa produkcja
                        (int)B_POLLUTION_POWERPLANT_WATER,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_POWERPLANT_WATER,    // Mnoznik kosztow
                        (int)B_MULT_PROD_POWERPLANT_WATER,     // Mnoznik produkcji
                        B_DESC_POWERPLANT_WATER //Opis
					)
                );

                this.Buildings.Add((int)B_POWERPLANT_WIND, // Klucz budynku
                    new _BaseBuilding(
                        "Elektrownia wiatrowa",               // Nazwa Budynku
                        "Power Panel",                          // Panel na ktorym budynek sie pojawia
                        R_POWER,                           // Surowiec jaki produkuje
                        R_NULL,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_POWERPLANT_WIND, // Ile Surowca wykorzystuje
                        (int)B_COST_POWERPLANT_WIND,         // Koszt podstawowy
                        (int)B_COST_POWERPLANT_WIND,         // Koszt aktualny
                        (int)B_TECH_POWERPLANT_WIND,         // Poziom technologii
                        5,                                      // Ilosc budynkow
                        (int)B_PROD_POWERPLANT_WIND,         // Bazowa produkcja
                        (int)B_POLLUTION_POWERPLANT_WIND,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_POWERPLANT_WIND,    // Mnoznik kosztow
                        (int)B_MULT_PROD_POWERPLANT_WIND,     // Mnoznik produkcji
                        B_DESC_POWERPLANT_WIND //Opis
					)
                );

                this.Buildings.Add((int)B_POWERPLANT_GAS, // Klucz budynku
	                new _BaseBuilding(
		                "Elektrownia gazowa",               // Nazwa Budynku
		                "Power Panel",                          // Panel na ktorym budynek sie pojawia
		                R_POWER,                           // Surowiec jaki produkuje
		                R_GAS,                            // Surowiec jaki wykorzystuje
		                (int)B_USED_RES_AMOUNT_POWERPLANT_GAS, // Ile Surowca wykorzystuje
		                (int)B_COST_POWERPLANT_GAS,         // Koszt podstawowy
		                (int)B_COST_POWERPLANT_GAS,         // Koszt aktualny
		                (int)B_TECH_POWERPLANT_GAS,         // Poziom technologii
		                0,                                      // Ilosc budynkow
		                (int)B_PROD_POWERPLANT_GAS,         // Bazowa produkcja
		                (int)B_POLLUTION_POWERPLANT_GAS,    // Generowane zanieczyszczenie
		                (int)B_MULT_COST_POWERPLANT_GAS,    // Mnoznik kosztow
		                (int)B_MULT_PROD_POWERPLANT_GAS,     // Mnoznik produkcji
		                B_DESC_POWERPLANT_GAS //Opis
	                )
                );

				//==================== BUDYNKI KOMUNALNE ====================

				this.Buildings.Add((int)B_TRASH_COMPOSTINGPLANT, // Klucz budynku
                    new _BaseBuilding(
                        "Kompostownia odpadów",               // Nazwa Budynku
                        "Trash Panel",                          // Panel na ktorym budynek sie pojawia
                        R_NULL,                           // Surowiec jaki produkuje
                        R_TRASH,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_TRASH_COMPOSTINGPLANT, // Ile Surowca wykorzystuje
                        (int)B_COST_TRASH_COMPOSTINGPLANT,         // Koszt podstawowy
                        (int)B_COST_TRASH_COMPOSTINGPLANT,         // Koszt aktualny
                        (int)B_TECH_TRASH_COMPOSTINGPLANT,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_TRASH_COMPOSTINGPLANT,         // Bazowa produkcja
                        (int)B_POLLUTION_TRASH_COMPOSTINGPLANT,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_TRASH_COMPOSTINGPLANT,    // Mnoznik kosztow
                        (int)B_MULT_PROD_TRASH_COMPOSTINGPLANT,     // Mnoznik produkcji
                        B_DESC_TRASH_COMPOSTINGPLANT //Opis
					)
                );

                this.Buildings.Add((int)B_TRASH_GARBAGEDUMP, // Klucz budynku
                    new _BaseBuilding(
                        "Wysypisko œmieci",               // Nazwa Budynku
                        "Trash Panel",                          // Panel na ktorym budynek sie pojawia
                        R_NULL,                           // Surowiec jaki produkuje
                        R_TRASH,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_TRASH_GARBAGEDUMP, // Ile Surowca wykorzystuje
                        (int)B_COST_TRASH_GARBAGEDUMP,         // Koszt podstawowy
                        (int)B_COST_TRASH_GARBAGEDUMP,         // Koszt aktualny
                        (int)B_TECH_TRASH_GARBAGEDUMP,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_TRASH_GARBAGEDUMP,         // Bazowa produkcja
                        (int)B_POLLUTION_TRASH_GARBAGEDUMP,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_TRASH_GARBAGEDUMP,    // Mnoznik kosztow
                        (int)B_MULT_PROD_TRASH_GARBAGEDUMP,     // Mnoznik produkcji
                        B_DESC_TRASH_GARBAGEDUMP //Opis
					)
                );

                this.Buildings.Add((int)B_TRASH_GARBAGEINCINERATOR, // Klucz budynku
                    new _BaseBuilding(
                        "Spalarnia œmieci",               // Nazwa Budynku
                        "Trash Panel",                          // Panel na ktorym budynek sie pojawia
                        R_NULL,                           // Surowiec jaki produkuje
                        R_TRASH,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_TRASH_GARBAGEINCINERATOR, // Ile Surowca wykorzystuje
                        (int)B_COST_TRASH_GARBAGEINCINERATOR,         // Koszt podstawowy
                        (int)B_COST_TRASH_GARBAGEINCINERATOR,         // Koszt aktualny
                        (int)B_TECH_TRASH_GARBAGEINCINERATOR,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_TRASH_GARBAGEINCINERATOR,         // Bazowa produkcja
                        (int)B_POLLUTION_TRASH_GARBAGEINCINERATOR,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_TRASH_GARBAGEINCINERATOR,    // Mnoznik kosztow
                        (int)B_MULT_PROD_TRASH_GARBAGEINCINERATOR,     // Mnoznik produkcji
                        B_DESC_TRASH_GARBAGEINCINERATOR //Opis
					)
                );

                this.Buildings.Add((int)B_TRASH_GARBAGESHIP, // Klucz budynku
                    new _BaseBuilding(
                        "Statek ³owi¹cy œmieci",               // Nazwa Budynku
                        "Trash Panel",                          // Panel na ktorym budynek sie pojawia
                        R_NULL,                           // Surowiec jaki produkuje
                        R_TRASH,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_TRASH_GARBAGESHIP, // Ile Surowca wykorzystuje
                        (int)B_COST_TRASH_GARBAGESHIP,         // Koszt podstawowy
                        (int)B_COST_TRASH_GARBAGESHIP,         // Koszt aktualny
                        (int)B_TECH_TRASH_GARBAGESHIP,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_TRASH_GARBAGESHIP,         // Bazowa produkcja
                        (int)B_POLLUTION_TRASH_GARBAGESHIP,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_TRASH_GARBAGESHIP,    // Mnoznik kosztow
                        (int)B_MULT_PROD_TRASH_GARBAGESHIP,     // Mnoznik produkcji
                        B_DESC_TRASH_GARBAGESHIP //Opis

					)
                );

                this.Buildings.Add((int)B_TRASH_RECYCLING, // Klucz budynku
                    new _BaseBuilding(
                        "Miejsce Recyklingu",               // Nazwa Budynku
                        "Trash Panel",                          // Panel na ktorym budynek sie pojawia
                        R_NULL,                           // Surowiec jaki produkuje
                        R_TRASH,                            // Surowiec jaki wykorzystuje
                        (int)B_USED_RES_AMOUNT_TRASH_RECYCLING, // Ile Surowca wykorzystuje
                        (int)B_COST_TRASH_RECYCLING,         // Koszt podstawowy
                        (int)B_COST_TRASH_RECYCLING,         // Koszt aktualny
                        (int)B_TECH_TRASH_RECYCLING,         // Poziom technologii
                        0,                                      // Ilosc budynkow
                        (int)B_PROD_TRASH_RECYCLING,         // Bazowa produkcja
                        (int)B_POLLUTION_TRASH_RECYCLING,    // Generowane zanieczyszczenie
                        (int)B_MULT_COST_TRASH_RECYCLING,    // Mnoznik kosztow
                        (int)B_MULT_PROD_TRASH_RECYCLING,     // Mnoznik produkcji
                        B_DESC_TRASH_RECYCLING //Opis
					)
                );
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
                buildingInstance.GenerateText.GetComponent<TMP_Text>().text = (_Build.BaseProduction * _Build.Amount).ToString() + " j.";
                buildingInstance.iBuildKey= this.Buildings.FirstOrDefault(x => x.Value.Equals(_Build)).Key;

                GameObject _Building = Instantiate(BuildingPrefab);
                _Building.transform.SetParent(GameObject.Find("UI/Canvas/Center Panel/Right Panel/Main Panel/"+_Build.PanelName).transform, false);
            }
        }

        public void Recalculate()
        {
            ResourceManager.Instance.ResetResourceForRecalculation();
            foreach (_BaseBuilding _Build in this.Buildings.Values)
            {
                _Build.RecalculateCost();
                _Build.RecalculateProduction();

                if (_Build.Resource != R_NULL)
                    ResourceManager.Instance.Resources[(int)_Build.Resource].Amount += _Build.Production;
                if (_Build.UsedResource != R_NULL)
                    ResourceManager.Instance.Resources[(int)_Build.UsedResource].UsedAmount += _Build.UsedResourceAmount * _Build.Amount;
            }
        }
    }
}
