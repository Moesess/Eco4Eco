namespace EcoGameCore
{
    public interface IBuilding {
        int Cost { get; set; }
        int Level { get; set; }
        int Production { get; set; }
        string Name { get; set; }
        Resource Resource { get; set; }
        Resource Pollution { get; set; }
    }
}
