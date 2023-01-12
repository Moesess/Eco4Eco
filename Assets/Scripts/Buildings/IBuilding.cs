namespace EcoGameCore
{
    public interface IBuilding {
        int Cost { get; set; }
        int Level { get; set; }
        int Amount { get; set; }
        int Production { get; set; }
        int Pollution { get; set; }
        string Name { get; set; }
        void Tick();
        void IncreaseLevel();
        void SetCost(int _iVal);
        void IncreaseAmount(int _iVal);
        void IncreaseAmount();
    }
}
