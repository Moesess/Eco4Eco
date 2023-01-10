using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ResourceManager;

public class AddBuildingScript : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton () {
        ResourceManager.Instance.AddPower(1);
    }
}