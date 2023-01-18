using System.Security.Cryptography;
using MyNamespace;
using Unity.VisualScripting;
using UnityEngine;

namespace EcoGame
{
    using System.Collections.Generic;
    using static Resources.RESOURCES;

    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance;

        public Dictionary<int, Resource> Resources = new();

		public Resource Power // Energia
        {
            get { return Resources[(int)R_POWER]; }
            set { this.Resources[(int)R_POWER] = value; }
        }
        public Resource Budget // Budzet
        {
            get { return Resources[(int)R_BUDGET]; }
            set { this.Resources[(int)R_BUDGET] = value; }
        }
        public Resource Trash // Smieci
        {
            get { return Resources[(int)R_TRASH]; }
            set { this.Resources[(int)R_TRASH] = value; }
        }
        public Resource Food // Zywnosc
        {
            get { return Resources[(int)R_FOOD]; }
            set { this.Resources[(int)R_FOOD] = value; }
        }
        public Resource Goods // Towary konsumpcyjne
        {
            get { return Resources[(int)R_GOODS]; }
            set { this.Resources[(int)R_GOODS] = value; }
        }
        public Resource Oil // Ropa naftowa
        {
            get { return Resources[(int)R_OIL]; }
            set { this.Resources[(int)R_OIL] = value; }
        }
        public Resource Coal // Wegiel
        {
            get { return Resources[(int)R_COAL]; }
            set { this.Resources[(int)R_COAL] = value; }
        }
        public Resource Gas // Gaz ziemny
        {
            get { return Resources[(int)R_GAS]; }
            set { this.Resources[(int)R_GAS] = value; }
        }
        public Resource Pollution // Œmieci
        {
            get { return Resources[(int)R_POLLUTION]; }
            set { this.Resources[(int)R_POLLUTION] = value; }
        }

        public Resource Uranium // Uran
        {
	        get { return Resources[(int)R_URANIUM]; }
	        set { this.Resources[(int)R_URANIUM] = value; }
        }
        public Resource Peat // Torf
        {
	        get { return Resources[(int)R_PEAT]; }
	        set { this.Resources[(int)R_PEAT] = value; }
        }
        public Resource Leaf // Listki
        {
	        get { return Resources[(int)R_LEAF]; }
	        set { this.Resources[(int)R_LEAF] = value; }
        }

		private void Awake()
        {
            // Set instance on scene awake
            if (Instance == null)
            {
	            Instance = this;
                this.Resources.Add((int)R_POWER, new Resource("Pr¹d", 0));
                this.Resources.Add((int)R_BUDGET, new Resource("Bud¿et", 0));
                this.Resources.Add((int)R_TRASH, new Resource("Œmieci", 0));
                this.Resources.Add((int)R_FOOD, new Resource("¯ywnoœæ", 0));
                this.Resources.Add((int)R_GOODS, new Resource("Towary konsumpcyjne", 0));
                this.Resources.Add((int)R_OIL, new Resource("Ropa naftowa", 0));
                this.Resources.Add((int)R_COAL, new Resource("Wêgiel", 0));
                this.Resources.Add((int)R_GAS, new Resource("Gaz ziemny", 0));
                this.Resources.Add((int)R_POLLUTION, new Resource("Zanieczyszczenie œrodowiska", 0));
                this.Resources.Add((int)R_URANIUM, new Resource("Uran", 0));
                this.Resources.Add((int)R_PEAT, new Resource("Torf", 0));
            }
        }

        private void Start()
        {
            this.Resources[(int)R_BUDGET].SetValue(1000000);
            this.Resources[(int)R_POLLUTION].SetValue(500);
        }
    }
}