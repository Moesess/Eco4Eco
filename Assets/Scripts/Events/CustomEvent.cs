using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Events
{
	internal class CustomEvent
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int PowerDifference { get; set; }
		public int BudgetDifference { get; set; }
		public int TrashDifference { get; set; }
		public int FoodDifference { get; set; }
		public int GoodsDifference { get; set; }
		public int OilDifference { get; set; }
		public int CoalDifference { get; set; }
		public int GasDifference { get; set; }
		public int PollutionDifference { get; set; }
		public int OilMineCoefficientDifference { get; set; }
		public int CoalmineCoefficientDifference { get; set; }
		public int GasMineCoefficientDifference { get; set; }


		public CustomEvent() { }
	}
}
