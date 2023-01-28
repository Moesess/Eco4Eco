using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace EcoGame
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        [SerializeField] GameObject InfoPanel;

        private void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            InvokeRepeating("TickPollution", 1f, 3f);  //1s delay, repeat every 3s
            InvokeRepeating("TickHappiness", 1f, 10f);  //1s delay, repeat every 3s

            this.InfoPanel.transform.Find("Text Group/Title").GetComponent<TMP_Text>().text = "Witamy w Eco4Eco!";
            this.InfoPanel.transform.Find("Text Group/Description").GetComponent<TMP_Text>().text = "Twoim zadaniem jest przeprowadzi� transformacj� energetyczn� kraju jakim przysz�o Ci sterowa�.\n\nZarz�dzaj surowcami i buduj budynki rozs�dnie, wa�nym czynnikiem jest r�wnie� zadowolenie spo�eczne.\n\nJe�li uda Ci si� osi�gn�� neutralno�� emisyjn� i odpowiednie zadowolenie spo�eczne, b�dziesz m�g� dokona� resetu. Otrzymasz listki kt�re mo�esz wyda� na specjalne technologie.\n\nGr� mo�esz opu�ci� wciskaj�c klawisz - ESC / Escape";
            GameObject panel = Instantiate(this.InfoPanel);
            panel.transform.SetParent(GameObject.Find("UI/Canvas").transform, false);
        }

        private void Update()
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
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
