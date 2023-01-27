namespace EcoGame
{
	public class CustomEvent
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


		public CustomEvent()
		{
			this.Id = 0;
			this.Title = "Template Title";
			this.Description = "Template description";
			this.PowerDifference = 0;
			this.BudgetDifference = 0;
			this.TrashDifference = 0;
			this.FoodDifference = 0;
			this.GoodsDifference = 0;
			this.OilDifference = 0;
			this.CoalDifference = 0;
			this.GasDifference = 0;
			this.PollutionDifference = 0;
			this.OilMineCoefficientDifference = 0;
			this.CoalmineCoefficientDifference = 0;
			this.GasMineCoefficientDifference = 0;
		}
    }
}
