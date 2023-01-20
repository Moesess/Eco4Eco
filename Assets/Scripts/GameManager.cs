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
            InvokeRepeating("Tick", 1f, 1f);  //1s delay, repeat every 1s
        }

        private void Update()
        {
            //Debug.Log(ResourceManager.Instance.Oil.sName + ResourceManager.Instance.Oil.iAmount);
            //Debug.Log(ResourceManager.Instance.Coal.sName + ResourceManager.Instance.Coal.iAmount);
            //Debug.Log(ResourceManager.Instance.Power.sName + ResourceManager.Instance.Power.iAmount);
            //Debug.Log(ResourceManager.Instance.Gas.sName + ResourceManager.Instance.Gas.iAmount);
        }

        // Metoda wywoluje tick we wszystkich budynkach
        void Tick()
        {
            //BuildingManager.Instance.Buildings[(int)B_MINE_OIL].Tick();
            //BuildingManager.Instance.Buildings[(int)B_MINE_COAL].Tick();
            //BuildingManager.Instance.Buildings[(int)B_MINE_GAS].Tick();
            //BuildingManager.Instance.Buildings[(int)B_MINE_URANIUM].Tick();
            //BuildingManager.Instance.Buildings[(int)B_POWERPLANT_COAL].Tick();
        }
    }
}
