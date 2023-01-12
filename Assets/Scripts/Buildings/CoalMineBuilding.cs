using EcoGame.Resources;
using System;

namespace EcoGame
{
    namespace Buildings
    {
        public class CoalMineBuilding : _BaseBuilding
        {
            public CoalMineBuilding()
            {
                this.Name = "Kopalnia wêgla";
                this.Amount = 1;
                this.BaseCost = 50;
                this.Level = 1;
                this.TechLevel = 1;
                this.Pollution = 3;
                RecalculateProduction();
                RecalculateCost();
            }

            public override void RecalculateCost() // Koszt jest przeliczany wzorem ---> iBaseCost * (1 + iLevel)^2 * (1 + iTechLevel?)^2
            {
                this.Cost = (int)(this.BaseCost * Math.Pow(this.Level + 1, 2) * Math.Pow(this.TechLevel + 1, 2));
            }

            public override void RecalculateProduction() // Produkcja jest przeliczana wzorem ---> (iLevel * iTechLevel)^3 * iAmount
            {
                this.Production = (int)Math.Pow(this.Level * this.TechLevel, 3) * this.Amount;
            }

            public override void Tick()
            {
                ResourceManager.Instance.Resources[ResourcesConsts.RESOURCE_COAL].Add(this.Production);
            }
        }
    }
}