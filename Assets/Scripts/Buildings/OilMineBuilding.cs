using UnityEngine;

namespace EcoGameCore
{
    namespace Buildings
    {
        public class OilMineBuilding : _BaseBuilding
        {
            public Resource Oil = ResourceManager.Instance.Resources[Resources.ResourcesConsts.RESOURCE_OIL];
            public OilMineBuilding()
            {

            }

            public override void Tick()
            {
                ResourceManager.Instance.Resources[Resources.ResourcesConsts.RESOURCE_OIL].Add(100);
            }
        }
    }
}