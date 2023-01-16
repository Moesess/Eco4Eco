using EcoGame.Resources;
using System;

namespace EcoGame
{
    namespace Buildings
    {
        public class PowerPlantBuilding : _BaseBuilding
        {
            public PowerPlantBuilding()
            {
                this.Name = "Elektrownia";
                this.PanelName = "Power Panel";
                this.Amount = 1;
                this.BaseCost = 100;
                this.Level = 1;
                this.TechLevel = 1;
                this.Pollution = 1;
                RecalculateProduction();
                RecalculateCost();
            }

            public override void RecalculateCost() // Koszt jest przeliczany wzorem ---> iBaseCost * (1 + iLevel)^2 * (1 + iTechLevel?)^2
            {
                this.Cost = (int)(this.BaseCost * Math.Pow(this.Level + 1, 2) * Math.Pow(this.TechLevel + 1, 2));
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