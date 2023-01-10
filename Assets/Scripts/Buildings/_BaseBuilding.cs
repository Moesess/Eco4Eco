using UnityEngine;

namespace EcoGameCore
{
    public class _BaseBuilding : MonoBehaviour, IBuilding
    {
        private int iCost; // Koszt budowy
        private int iLevel; // Poziom budynku
        private int iProduction; // Produkcja surowca res
        private string sName; // Nazwa budynku
        private Resource pol; // Zanieczyszczenia
        private Resource res; // Surowiec ktory produkuje budynek 

        // Gettery settery
        public int Cost
        {
            get { return this.iCost; }
            set { this.iCost = value; }
        }
        public int Level
        {
            get { return this.iLevel; }
            set { this.iLevel = value; }
        }
        public int Production
        {
            get { return this.iProduction; }
            set { this.iProduction = value; }
        }
        public string Name
        {
            get { return this.sName; }
            set { this.sName = value; }
        }
        public Resource Resource
        {
            get { return this.res; }
            set { this.res = value; }
        }
        public Resource Pollution
        {
            get { return this.pol; }
            set { this.pol = value; }
        }

        // Metody
    }
}
