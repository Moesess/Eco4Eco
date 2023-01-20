using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListFiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	    for (int i = 0; i < numberOfObjects; i++)
	    {
		    var newlistElement = Instantiate(listElement);
		    newlistElement.transform.SetParent(parentObject.transform);
	    }
    }

    [SerializeField] 
    public GameObject listElement;
    [SerializeField]
    public int numberOfObjects;
    [SerializeField] 
    public GameObject parentObject;
}
