namespace EcoGame
{
    public interface IBuilding {
        int BaseCost { get; set; }
        int Cost { get; set; }
        int TechLevel { get; set; }
        int Amount { get; set; }
        int Production { get; set; }
        int Pollution { get; set; }
        string Name { get; set; }
        string PanelName { get; set; }
        //void Tick();
        void SetCost(int _iVal);
        void IncreaseAmount();
        void DecreaseAmount();
    }
}
