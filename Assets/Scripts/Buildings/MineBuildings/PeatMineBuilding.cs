using System;

namespace EcoGame
{
    using static Resources.RESOURCES;

    namespace Buildings
    {
        public class PeatMineBuilding : _BaseBuilding
        {
            public PeatMineBuilding()
            {
                this.Name = "Kopalnia torfu";
				this.PanelName = "Mine Panel";
				this.Amount = 1;
                this.BaseCost = 100;
                this.TechLevel = 1;
                this.Pollution = 2;
                RecalculateProduction();
                RecalculateCost();
            }

            public override void RecalculateCost() // Koszt jest przeliczany wzorem ---> iBaseCost * (1 + iLevel)^2 * (1 + iTechLevel?)^2
            {
                this.Cost = (int)(this.BaseCost * Math.Pow(this.TechLevel + 1, 3));
            }

            public override void RecalculateProduction() // Produkcja jest przeliczana wzorem ---> (iLevel * iTechLevel)^2 * iAmount
            {
                this.Production = (int)Math.Pow(this.TechLevel, 2) * this.Amount;
            }

            public override void Tick()
            {
                ResourceManager.Instance.Resources[(int)RESOURCE_PEAT].Add(this.Production);
            }
        }
    }
}