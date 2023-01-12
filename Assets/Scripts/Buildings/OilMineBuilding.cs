using System;
using UnityEngine;

namespace EcoGame
{
    using Resources;

    namespace Buildings
    {
        public class OilMineBuilding : _BaseBuilding
        {
            public Resource Oil = ResourceManager.Instance.Resources[ResourcesConsts.RESOURCE_OIL];
            public OilMineBuilding()
            {
                this.Name = "Kopalnia ropy naftowej";
                this.Amount = 1;
                this.BaseCost = 100;
                this.Level = 1;
                this.TechLevel = 1;
                this.Pollution = 2;
                RecalculateProduction();
                RecalculateCost();
            }

            public override void RecalculateCost() // Koszt jest przeliczany wzorem ---> iBaseCost * (1 + iLevel)^2 * (1 + iTechLevel?)^2
            {
                this.Cost = (int)(this.BaseCost * Math.Pow(this.Level + 1, 3) * Math.Pow(this.TechLevel + 1, 3));
            }

            public override void RecalculateProduction() // Produkcja jest przeliczana wzorem ---> (iLevel * iTechLevel)^2 * iAmount
            {
                this.Production = (int)Math.Pow(this.Level * this.TechLevel, 2) * this.Amount;
            }

            public override void Tick()
            {
                ResourceManager.Instance.Resources[ResourcesConsts.RESOURCE_OIL].Add(this.Production);
            }
        }
    }
}