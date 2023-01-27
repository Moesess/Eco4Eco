using UnityEngine;

namespace EcoGame
{
    public class CustomEventInstance : MonoBehaviour
    {
        [SerializeField] public GameObject EventPanel;
        [SerializeField] public GameObject TitlePlaceholder;
        [SerializeField] public GameObject DescriptionPlaceholder;
        public CustomEvent Event;

        public void YesAction()
        {
            //something happens
            Destroy(EventPanel);
        }
        public void NoAction()
        {
            //something happens
            Destroy(EventPanel);
        }
    }
}
