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

        private void Update()
        {
            Debug.Log(ResourceManager.Instance.Oil.sName + ResourceManager.Instance.Oil.iAmount);
            Debug.Log(BuildingManager.Instance.Buildings[BuildingConsts.BUILDING_MINE_OIL].Level);
        }
    }
}
