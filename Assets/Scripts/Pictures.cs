using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pictures : MonoBehaviour
{
    [SerializeField] public Texture2D BudgetPicture;
    [SerializeField] public Texture2D TrashPicture;
    [SerializeField] public Texture2D EnergyPicture;
    [SerializeField] public Texture2D FoodPicture;
    [SerializeField] public Texture2D GoodsPicture;
    [SerializeField] public Texture2D OilPicture;
    [SerializeField] public Texture2D CoalPicture;
    [SerializeField] public Texture2D GasPicture;
    [SerializeField] public Texture2D UraniumPicture;
    [SerializeField] public Texture2D PeatPicture;

    public static Pictures Instance;

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
}
