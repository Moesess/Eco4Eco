using UnityEngine;

namespace EcoGameCore
{
    using Buildings;
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
            Debug.Log(ResourceManager.Instance.Oil.sName + ResourceManager.Instance.Oil.iAmount);
            Debug.Log(BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Level);
        }

        // Metoda wywoluje tick we wszystkich budynkach
        void Tick()
        {
            BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Tick();
        }
    }
}
