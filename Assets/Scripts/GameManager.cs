using UnityEngine;

namespace EcoGame
{
    using static Buildings.BUILDINGS;
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            InvokeRepeating("TickPollution", 1f, 3f);  //1s delay, repeat every 3s
            InvokeRepeating("TickHappiness", 1f, 10f);  //1s delay, repeat every 3s
        }

        // Metoda wywoluje tick we wszystkich budynkach
        void TickHappiness()
        {
            if (ResourceManager.Instance.PollutionEffectPercent == 0.8f)
                ResourceManager.Instance.Resources[(int)Resources.RESOURCES.R_HAPPY].Amount--;
            if (ResourceManager.Instance.PollutionEffectPercent == 1f)
                ResourceManager.Instance.Resources[(int)Resources.RESOURCES.R_HAPPY].Amount++;
        }

        void TickPollution()
        {
            // Naturalne zmniejszanie pollution
            ResourceManager.Instance.Resources[(int)Resources.RESOURCES.R_POLLUTION].Amount--;

            foreach (_BaseBuilding Building in BuildingManager.Instance.Buildings.Values)
            {
                if(Building.Amount > 0)
                    Building.TickPollution();
            }
        }
    }
}
