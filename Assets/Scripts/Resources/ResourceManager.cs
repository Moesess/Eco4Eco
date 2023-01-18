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
            get { return Resources[(int)RESOURCE_POWER]; }
            set { this.Resources[(int)RESOURCE_POWER] = value; }
        }
        public Resource Budget // Budzet
        {
            get { return Resources[(int)RESOURCE_BUDGET]; }
            set { this.Resources[(int)RESOURCE_BUDGET] = value; }
        }
        public Resource Trash // Smieci
        {
            get { return Resources[(int)RESOURCE_TRASH]; }
            set { this.Resources[(int)RESOURCE_TRASH] = value; }
        }
        public Resource Food // Zywnosc
        {
            get { return Resources[(int)RESOURCE_FOOD]; }
            set { this.Resources[(int)RESOURCE_FOOD] = value; }
        }
        public Resource Goods // Towary konsumpcyjne
        {
            get { return Resources[(int)RESOURCE_GOODS]; }
            set { this.Resources[(int)RESOURCE_GOODS] = value; }
        }
        public Resource Oil // Ropa naftowa
        {
            get { return Resources[(int)RESOURCE_OIL]; }
            set { this.Resources[(int)RESOURCE_OIL] = value; }
        }
        public Resource Coal // Wegiel
        {
            get { return Resources[(int)RESOURCE_COAL]; }
            set { this.Resources[(int)RESOURCE_COAL] = value; }
        }
        public Resource Gas // Gaz ziemny
        {
            get { return Resources[(int)RESOURCE_GAS]; }
            set { this.Resources[(int)RESOURCE_GAS] = value; }
        }
        public Resource Pollution // Œmieci
        {
            get { return Resources[(int)RESOURCE_POLLUTION]; }
            set { this.Resources[(int)RESOURCE_POLLUTION] = value; }
        }

        public Resource Uranium // Uran
        {
	        get { return Resources[(int)RESOURCE_URANIUM]; }
	        set { this.Resources[(int)RESOURCE_URANIUM] = value; }
        }
        public Resource Peat // Torf
        {
	        get { return Resources[(int)RESOURCE_PEAT]; }
	        set { this.Resources[(int)RESOURCE_PEAT] = value; }
        }
        public Resource Leaf // Listki
        {
	        get { return Resources[(int)RESOURCE_LEAF]; }
	        set { this.Resources[(int)RESOURCE_LEAF] = value; }
        }

		private void Awake()
        {
            // Set instance on scene awake
            if (Instance == null)
            {
	            Instance = this;
				this.Resources.Add((int)RESOURCE_POWER, new Resource("Pr¹d", 0));
				this.Resources.Add((int)RESOURCE_BUDGET, new Resource("Bud¿et", 1000000));
				this.Resources.Add((int)RESOURCE_TRASH, new Resource("Œmieci", 0));
				this.Resources.Add((int)RESOURCE_FOOD, new Resource("¯ywnoœæ", 0));
				this.Resources.Add((int)RESOURCE_GOODS, new Resource("Towary konsumpcyjne", 0));
				this.Resources.Add((int)RESOURCE_OIL, new Resource("Ropa naftowa", 0));
				this.Resources.Add((int)RESOURCE_COAL, new Resource("Wêgiel", 0));
				this.Resources.Add((int)RESOURCE_GAS, new Resource("Gaz ziemny", 0));
				this.Resources.Add((int)RESOURCE_POLLUTION, new Resource("Zanieczyszczenie œrodowiska", 1000));
				this.Resources.Add((int)RESOURCE_URANIUM, new Resource("Uran", 0));
				this.Resources.Add((int)RESOURCE_PEAT, new Resource("Torf", 0));
                this.Resources.Add((int)RESOURCE_LEAF, new Resource("Listek",0));
			}
        }

        private void Start()
        {
            this.Resources[(int)RESOURCE_BUDGET].SetValue(1000000);
            this.Resources[(int)RESOURCE_POLLUTION].SetValue(1000);
        }
    }
}