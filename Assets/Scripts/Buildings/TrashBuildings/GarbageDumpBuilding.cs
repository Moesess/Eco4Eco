using System;

namespace EcoGame
{
    using static Resources.RESOURCES;
    namespace Buildings
	{
		public class GarbageDumpBuilding : _BaseBuilding
		{
			public GarbageDumpBuilding()
			{
				this.Name = "Wysypisko �mieci";
				this.PanelName = "Trash Panel";
				this.Amount = 1;
				this.BaseCost = 100;
				this.TechLevel = 1;
				this.Pollution = 1;
				RecalculateProduction();
				RecalculateCost();
			}

			public override void RecalculateCost() // Koszt jest przeliczany wzorem ---> iBaseCost * (1 + iTechLevel?)^2
			{
				this.Cost = (int)(this.BaseCost * Math.Pow(this.TechLevel + 1, 2));
			}

			public override void RecalculateProduction() // Produkcja jest przeliczana wzorem ---> (iTechLevel)^2 * iAmount
			{
				this.Production = (int)Math.Pow(this.TechLevel, 2) * this.Amount;
			}

			public override void Tick()
			{
				ResourceManager.Instance.Resources[(int)RESOURCE_TRASH].Add(this.Production);
			}
		}
	}
}