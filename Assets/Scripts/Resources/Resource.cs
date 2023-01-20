using EcoGame.Resources;
using System;

namespace EcoGame
{
    using static EcoGame.Resources.RESOURCE_PRICES;

    public class Resource
    {
        /// 
        /// Klasa Surowca, posiada pola:
        /// - WYMAGANE: Name, nazwa surowca glownie do wyswietlania czy ewentualnego kluczowania
        /// - WYMAGANE: Amount, AKTUALNA ilosc produkcji danego surowca, np 10 oznacza ze mamy do dyspozycji 10 jednostek np. wegla.
        /// - OPCJONALNE: MaxAmount, maksymalna ilosc danego surowca, wykorzystywane do niektorych surowcow typu zanieczyszczenie czy zadowolenie spoleczne. Do przeliczania procentow
        /// - OPCJONALNE: UsedAmount, AKTUALNE ZUZYCIE danego surowca. Wykorzystywane do zdefiniowania czy mozemy miec aktywowana np elektrownie weglowa
        /// 
        /// EVENTY:
        /// - OnIAmountChange, wywolywany gdy zmieni sie AKTUALNA wartosc danego surowca
        /// - OnIUsedAmountChange, wywolywany gdy zmieni sie UZYCIE danego surowca
        /// 

        private string sName; // Nazwa surowca
		private int iAmount; // Ilosc surowca
		private int iMaxAmount; // Maksymalna ilosc surowca
		private int iUsedAmount; // Uzywana ilosc surowca
		private int iPrice;      // Cena surowca

		public int Amount
        {
            get { return iAmount; }
            set 
            {
                iAmount = value;
                if(OnAmountChange != null) OnAmountChange();
            }
        }

        public int UsedAmount
        {
            get { return iUsedAmount; }
            set
            {
                iUsedAmount = value;
                if (OnAmountChange != null) OnUsedAmountChange();
            }
        }

        public int MaxAmount
        {
            get { return iMaxAmount; }
            set { iMaxAmount = value; }
        }

        public string Name { 
            get { return sName; } 
            set { sName = value; }
        }

        public int Price
        {
            get { return iPrice; }
            set { iPrice = value; }
        }


        public delegate void OnIChangeDelegate();
        public event OnIChangeDelegate OnAmountChange;
        public event OnIChangeDelegate OnUsedAmountChange;

// Konstruktory ============================================================

        public Resource()
        {
            this.sName = "";
            this.Amount = 0;
            this.MaxAmount = 0;
            this.UsedAmount = 0;
        }
        public Resource(int _iVal)
        {
            this.sName = "";
            this.Amount = _iVal;
            this.MaxAmount = 0;
            this.UsedAmount = 0;
        }
        public Resource(string _sName)
        {
            this.sName = _sName;
            this.Amount = 0;
            this.MaxAmount = 0;
            this.UsedAmount = 0;
        }

        public Resource(string _sName, int _iVal)
        {
            this.sName = _sName;
            this.Amount = _iVal;
            this.MaxAmount = 0;
            this.UsedAmount = 0;
        }

        public Resource(string _sName, int _iVal, RESOURCE_PRICES _iPrice)
        {
            this.sName = _sName;
            this.Amount = _iVal;
            this.MaxAmount = 0;
            this.UsedAmount = 0;
            this.Price = (int)_iPrice;
        }

        public Resource(Resource _Res)
        {
            this.sName = _Res.Name;
            this.Amount = _Res.Amount;
            this.MaxAmount = _Res.MaxAmount;
            this.UsedAmount = _Res.UsedAmount;
        }

        public Resource(string _sName, int _iAmount, int _iMax, int _iUsed, int _iPrice)
        {
            this.sName = _sName;
            this.Amount = _iAmount;
            this.MaxAmount = _iMax;
            this.UsedAmount = _iUsed;
            this.Price = _iPrice;
        }

        // Operatory ===============================================================
        public static Resource operator +(Resource _Res1, Resource _Res2)
        {
            if (_Res1.sName == _Res2.sName)
                return new Resource(_Res1.sName, _Res1.Amount + _Res2.Amount);
            else
                throw new Exception("Invalid resource type exception");
        }

        public static Resource operator +(Resource _Res1, int _iRes2)
        {
            return new Resource(_Res1.sName, _Res1.Amount + _iRes2);
        }

        public static Resource operator -(Resource _Res1, Resource _Res2)
        {
            if (_Res1.sName == _Res2.sName)
            {
                if(_Res1.Amount - _Res2.Amount < 0)
                    return new Resource(_Res1.sName, 0);
                return new Resource(_Res1.sName, _Res1.Amount - _Res2.Amount);
            }
            else
                throw new Exception("Invalid resource type exception");
        }

        public static Resource operator -(Resource _Res1, int _iRes2)
        {
            if(_Res1.Amount - _iRes2 < 0)
                return new Resource(_Res1.sName, 0);

            return new Resource(_Res1.sName, _Res1.Amount - _iRes2);
        }

        public static bool operator <(Resource _Res1, int _iRes2)
        {
            return (_Res1.Amount < _iRes2);
        }

        public static bool operator >(Resource _Res1, int _iRes2)
        {
            return (_Res1.Amount > _iRes2);
        }

        public static bool operator ==(Resource _Res1, int _iRes2)
        {
            return (_Res1.Amount == _iRes2);
        }

        public static bool operator !=(Resource _Res1, int _iRes2)
        {
            return (_Res1.Amount != _iRes2);
        }

        public static bool operator <(Resource _Res1, Resource _Res2)
        {
            return (_Res1.Amount < _Res2.Amount);
        }

        public static bool operator >(Resource _Res1, Resource _Res2)
        {
            return (_Res1.Amount > _Res2.Amount);
        }

        public static bool operator ==(Resource _Res1, Resource _Res2)
        {
            return (_Res1.Amount == _Res2.Amount);
        }

        public static bool operator !=(Resource _Res1, Resource _Res2)
        {
            return (_Res1.Amount != _Res2.Amount);
        }

        public override bool Equals(System.Object _Obj)
        {
            if ((_Obj == null) || !(this.GetType().Equals(_Obj.GetType())))
            {
                return false;
            }
            else
            {
                Resource _Res = (Resource)_Obj;
                return ((this.Amount == _Res.Amount) && (this.sName == _Res.sName));
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sName, Amount);
        }

        // Metody
        public void Add(int _iVal)
        {
            if(this.Amount + _iVal <= 0)
            {
                this.Amount = 0;
            } 
            else if(this.Amount + _iVal > MaxAmount)
            {
                this.Amount = MaxAmount;
            }
            else
                this.Amount += _iVal;
        }

        public void Subtract(int _iVal)
        {
            if (this.Amount - _iVal <= 0)
            {
                this.Amount = 0;
            }
            else if (this.Amount - _iVal > MaxAmount)
            {
                this.Amount = MaxAmount;
            }
            else
                this.Amount -= _iVal;
        }

        public void SetValue(int _iVal)
        {
            if(_iVal < 0)
                this.Amount = 0;
            else
                this.Amount = _iVal;
        }

        public void SetUsedValue(int _iVal)
        {
            if(_iVal < 0)
                this.UsedAmount = 0;
            else
                this.UsedAmount = _iVal;
        }
    }
}
