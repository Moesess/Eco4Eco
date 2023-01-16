using UnityEngine;

namespace EcoGame
{
    using Resources;
    using System;
    using System.Collections.Generic;
    using UnityEngine.UIElements;

    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance;

        public Dictionary<string, Resource> Resources = new();

		public Resource Power // Energia
        {
            get { return Resources[ResourcesConsts.RESOURCE_POWER]; }
            set { this.Resources[ResourcesConsts.RESOURCE_POWER] = value; }
        }
        public Resource Budget // Budzet
        {
            get { return Resources[ResourcesConsts.RESOURCE_BUDGET]; }
            set { this.Resources[ResourcesConsts.RESOURCE_BUDGET] = value; }
        }
        public Resource Trash // Smieci
        {
            get { return Resources[ResourcesConsts.RESOURCE_TRASH]; }
            set { this.Resources[ResourcesConsts.RESOURCE_TRASH] = value; }
        }
        public Resource Food // Zywnosc
        {
            get { return Resources[ResourcesConsts.RESOURCE_FOOD]; }
            set { this.Resources[ResourcesConsts.RESOURCE_FOOD] = value; }
        }
        public Resource Goods // Towary konsumpcyjne
        {
            get { return Resources[ResourcesConsts.RESOURCE_GOODS]; }
            set { this.Resources[ResourcesConsts.RESOURCE_GOODS] = value; }
        }
        public Resource Oil // Ropa naftowa
        {
            get { return Resources[ResourcesConsts.RESOURCE_OIL]; }
            set { this.Resources[ResourcesConsts.RESOURCE_OIL] = value; }
        }
        public Resource Coal // Wegiel
        {
            get { return Resources[ResourcesConsts.RESOURCE_COAL]; }
            set { this.Resources[ResourcesConsts.RESOURCE_COAL] = value; }
        }
        public Resource Gas // Gaz ziemny
        {
            get { return Resources[ResourcesConsts.RESOURCE_GAS]; }
            set { this.Resources[ResourcesConsts.RESOURCE_GAS] = value; }
        }
        public Resource Pollution // Œmieci
        {
            get { return Resources[ResourcesConsts.RESOURCE_POLLUTION]; }
            set { this.Resources[ResourcesConsts.RESOURCE_POLLUTION] = value; }
        }

        public Resource Uranium // Uran
        {
	        get { return Resources[ResourcesConsts.RESOURCE_URANIUM]; }
	        set { this.Resources[ResourcesConsts.RESOURCE_URANIUM] = value; }
        }
        public Resource Peat // Torf
        {
	        get { return Resources[ResourcesConsts.RESOURCE_PEAT]; }
	        set { this.Resources[ResourcesConsts.RESOURCE_PEAT] = value; }
        }

		private void Awake()
        {
            // Set instance on scene awake
            if (Instance == null)
            {
                Instance = this;
                this.Resources.Add(ResourcesConsts.RESOURCE_POWER, new Resource("Pr¹d", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_BUDGET, new Resource("Bud¿et", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_TRASH, new Resource("Œmieci", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_FOOD, new Resource("¯ywnoœæ", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_GOODS, new Resource("Towary konsumpcyjne", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_OIL, new Resource("Ropa naftowa", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_COAL, new Resource("Wêgiel", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_GAS, new Resource("Gaz ziemny", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_POLLUTION, new Resource("Zanieczyszczenie œrodowiska", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_URANIUM, new Resource("Uran", 0));
                this.Resources.Add(ResourcesConsts.RESOURCE_PEAT, new Resource("Torf", 0));
			}
        }

        private void Start()
        {
            this.Resources[ResourcesConsts.RESOURCE_BUDGET].SetValue(1000000);
        }
    }
}