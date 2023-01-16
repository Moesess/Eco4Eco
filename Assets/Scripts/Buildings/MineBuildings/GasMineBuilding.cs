using EcoGame.Resources;
using System;

namespace EcoGame
{
    namespace Buildings
    {
        public class GasMineBuilding : _BaseBuilding
        {
            public GasMineBuilding()
            {
                this.Name = "Kopalnia gazu ziemnego";
				this.PanelName = "Mine Panel";
				this.Amount = 1;
                this.BaseCost = 300;
                this.TechLevel = 1;
                this.Pollution = 1;
                RecalculateProduction();
                RecalculateCost();
            }

            public override void RecalculateCost()
            {
                this.Cost = (int)(this.BaseCost * Math.Pow(this.TechLevel + 1, 2));
            }

            public override void RecalculateProduction()
            {
                this.Production = (int)Math.Pow( this.TechLevel, 4) * this.Amount;
            }

            public override void Tick()
            {
                ResourceManager.Instance.Resources[ResourcesConsts.RESOURCE_GAS].Add(this.Production);
            }
        }
    }
}
