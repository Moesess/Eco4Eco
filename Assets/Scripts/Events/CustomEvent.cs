namespace EcoGame
{
	public class CustomEvent
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string EffectYesDescription { get; set; }
		public string EffectNoDescription { get; set; }
		public int YesProductionAmount { get; set; }
		public int NoProductionAmount { get; set; }
		public int YesHappinessAmount { get; set; }
		public int NoHappinessAmount { get; set; }
		public int BuildingKey { get; set; }


		public CustomEvent()
		{
			this.Id = 0;
			this.Title = "Template Title";
			this.Description = "Template description";
			this.EffectYesDescription = "Click YES";
			this.EffectNoDescription = "Click NO";
			this.YesProductionAmount = 0;
			this.NoProductionAmount = 0;
			this.YesHappinessAmount = 0;
			this.NoHappinessAmount = 0;
			this.BuildingKey = 0;
		}
    }
}
