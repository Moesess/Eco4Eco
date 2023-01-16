using System;
using UnityEngine;

namespace EcoGame
{
    public class Resource
    {
        public string sName; // Nazwa surowca
		private int iAmount; // Ilosc surowca
		public int Amount
        {
            get { return iAmount; }
            set 
            {
                iAmount = value;
                if(OnIAmountChange != null) OnIAmountChange(iAmount);
            }
        }

		public delegate void OnIAmountChangeDelegate(int newAmount);
        public event OnIAmountChangeDelegate OnIAmountChange;

// Konstruktory ============================================================

        public Resource()
        {
            this.sName = "";
            this.Amount = 0;
        }
        public Resource(int _iVal)
        {
            this.sName = "";
            this.Amount = _iVal;
        }
        public Resource(string _sName)
        {
            this.sName = _sName;
            this.Amount = 0;
        }
        public Resource(string _sName, int _iVal)
        {
            this.sName = _sName;
            this.Amount = _iVal;
        }
        public Resource(Resource _Res)
        {
            this.sName = _Res.sName;
            this.Amount = _Res.iAmount;
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
                return new Resource(_Res1.sName, _Res1.Amount - _Res2.Amount);
            else
                throw new Exception("Invalid resource type exception");
        }

        public static Resource operator -(Resource _Res1, int _iRes2)
        {
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
            this.Amount += _iVal; 

            if(this.Amount < 0)
            {
                this.Amount = 0;
            }
        }

        public void SetValue(int _iVal)
        {
            if(_iVal < 0)
                this.Amount = 0;
            else
                this.Amount = _iVal;
        }
    }
}
