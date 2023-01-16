using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EcoGame.Resources;
using System;

namespace EcoGame
{
	namespace Buildings
	{
		public class BiomassPowerPlantBuilding : _BaseBuilding
		{
			public BiomassPowerPlantBuilding()
			{
				this.Name = "Elektrownia na biomas�";
				this.PanelName = "Power Panel";
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
				ResourceManager.Instance.Resources[ResourcesConsts.RESOURCE_POWER].Add(this.Production);
			}
		}
	}
}