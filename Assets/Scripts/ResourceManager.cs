using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;

    private int iPower;  // Energia
    private int iBudget; // Budzet
    private int iTrash;  // Smieci
    private int iFood;   // Zywnosc
    private int iGoods;  // Towary konsumpcyjne

    private void Awake() {
        // Set instance on scene awake
        Instance = this;
    }

    public int GetPower()   { return iPower;  }
    public int GetBudget()  { return iBudget; }
    public int GetTrash()   { return iTrash;  }
    public int GetFood()    { return iFood;   }
    public int GetGoods()   { return iGoods;  }

    public void SetPower( int _iPower )     { this.iPower   = _iPower;  }
    public void SetBudget( int _iBudget )   { this.iBudget  = _iBudget; }
    public void SetTrash( int _iTrash )     { this.iTrash   = _iTrash;  }
    public void SetFood( int _iFood )       { this.iFood    = _iFood;   }
    public void SetGoods( int _iGoods )     { this.iGoods   = _iGoods;  }

    public void AddPower( int _iValue ) { 
        this.iPower += _iValue;

        if (this.iPower < 0) this.iPower = 0;
    }

    public void AddBudget( int _iValue ) { 
        this.iBudget += _iValue; 

        if (this.iBudget < 0) this.iBudget = 0;
    }
    
    public void AddTrash( int _iValue ) { 
        this.iTrash += _iValue;

        if (this.iTrash < 0) this.iTrash = 0;
    }
    
    public void AddFood( int _iValue ) { 
        this.iFood += _iValue;

        if (this.iFood < 0) this.iFood = 0;
    }
    
    public void AddGoods( int _iValue ) { 
        this.iGoods += _iValue;

        if (this.iGoods < 0) this.iGoods = 0;
    }
}
