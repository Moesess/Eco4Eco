using System;
using UnityEngine;

namespace EcoGame
{
    public class Resource
    {
        public string sName; // Nazwa surowca
        public int iAmount; // Ilosc surowca

// Konstruktory ============================================================

        public Resource()
        {
            this.sName = "";
            this.iAmount = 0;
        }
        public Resource(int _iVal)
        {
            this.sName = "";
            this.iAmount = _iVal;
        }
        public Resource(string _sName)
        {
            this.sName = _sName;
            this.iAmount = 0;
        }
        public Resource(string _sName, int _iVal)
        {
            this.sName = _sName;
            this.iAmount = _iVal;
        }
        public Resource(Resource _Res)
        {
            this.sName = _Res.sName;
            this.iAmount = _Res.iAmount;
        }

        // Operatory ===============================================================
        public static Resource operator +(Resource _Res1, Resource _Res2)
        {
            if (_Res1.sName == _Res2.sName)
                return new Resource(_Res1.sName, _Res1.iAmount + _Res2.iAmount);
            else
                throw new Exception("Invalid resource type exception");
        }

        public static Resource operator +(Resource _Res1, int _iRes2)
        {
            return new Resource(_Res1.sName, _Res1.iAmount + _iRes2);
        }

        public static Resource operator -(Resource _Res1, Resource _Res2)
        {
            if (_Res1.sName == _Res2.sName)
                return new Resource(_Res1.sName, _Res1.iAmount - _Res2.iAmount);
            else
                throw new Exception("Invalid resource type exception");
        }

        public static Resource operator -(Resource _Res1, int _iRes2)
        {
            return new Resource(_Res1.sName, _Res1.iAmount - _iRes2);
        }

        public static bool operator <(Resource _Res1, int _iRes2)
        {
            return (_Res1.iAmount < _iRes2);
        }

        public static bool operator >(Resource _Res1, int _iRes2)
        {
            return (_Res1.iAmount > _iRes2);
        }

        public static bool operator ==(Resource _Res1, int _iRes2)
        {
            return (_Res1.iAmount == _iRes2);
        }

        public static bool operator !=(Resource _Res1, int _iRes2)
        {
            return (_Res1.iAmount != _iRes2);
        }

        public static bool operator <(Resource _Res1, Resource _Res2)
        {
            return (_Res1.iAmount < _Res2.iAmount);
        }

        public static bool operator >(Resource _Res1, Resource _Res2)
        {
            return (_Res1.iAmount > _Res2.iAmount);
        }

        public static bool operator ==(Resource _Res1, Resource _Res2)
        {
            return (_Res1.iAmount == _Res2.iAmount);
        }

        public static bool operator !=(Resource _Res1, Resource _Res2)
        {
            return (_Res1.iAmount != _Res2.iAmount);
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
                return ((this.iAmount == _Res.iAmount) && (this.sName == _Res.sName));
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sName, iAmount);
        }

        // Metody
        public void Add(int _iVal)
        {
            this.iAmount += _iVal; 

            if(this.iAmount < 0)
            {
                this.iAmount = 0;
            }
        }

        public void SetValue(int _iVal)
        {
            if(_iVal < 0)
                this.iAmount = 0;
            else
                this.iAmount = _iVal;
        }
    }
}
