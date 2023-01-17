using EcoGame.Resources;
using UnityEngine;
using UnityEngine.UI;

namespace EcoGame
{
    public class PollutionBar : MonoBehaviour
    {
        private float maximum;
        [SerializeField] public Image mask;

        private void Start()
        {
            ResourceManager.Instance.Resources[(int)RESOURCES.RESOURCE_POLLUTION].OnIAmountChange += GetCurrentFill;
            this.maximum = (float)RESOURCES.RESOURCE_POLLUTION_MAXIMUM;
        }

        void GetCurrentFill(int _iVal)
        {
            float fCurrent = _iVal - 0f;
            mask.fillAmount = (fCurrent / maximum);
        }
    }
}
