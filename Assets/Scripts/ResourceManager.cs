using UnityEngine;

namespace EcoGameCore {
    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance;

        private Resource iPower;  // Energia
        private Resource iBudget; // Budzet
        private Resource iTrash;  // Smieci
        private Resource iFood;   // Zywnosc
        private Resource iGoods;  // Towary konsumpcyjne

        private void Awake()
        {
            // Set instance on scene awake
            if( Instance == null)
                Instance = this;
        }

        public Resource GetPower() { return iPower; }
        public Resource GetBudget() { return iBudget; }
        public Resource GetTrash() { return iTrash; }
        public Resource GetFood() { return iFood; }
        public Resource GetGoods() { return iGoods; }

        public void SetPower(int _iPower) { this.iPower = new Resource(_iPower); }
        public void SetBudget(int _iBudget) { this.iBudget = new Resource(_iBudget); }
        public void SetTrash(int _iTrash) { this.iTrash = new Resource(_iTrash); }
        public void SetFood(int _iFood) { this.iFood = new Resource(_iFood); }
        public void SetGoods(int _iGoods) { this.iGoods = new Resource(_iGoods); }

        public void AddPower(int _iValue)
        {
            this.iPower += _iValue;

            if (this.iPower < 0) this.iPower = new Resource(0);
        }

        public void AddBudget(int _iValue)
        {
            this.iBudget += _iValue;

            if (this.iBudget < 0) this.iBudget = new Resource(0);
        }

        public void AddTrash(int _iValue)
        {
            this.iTrash += _iValue;

            if (this.iTrash < 0) this.iTrash = new Resource(0);
        }

        public void AddFood(int _iValue)
        {
            this.iFood += _iValue;

            if (this.iFood < 0) this.iFood = new Resource(0);
        }

        public void AddGoods(int _iValue)
        {
            this.iGoods += _iValue;

            if (this.iGoods < 0) this.iGoods = new Resource(0);
        }
    }
}
