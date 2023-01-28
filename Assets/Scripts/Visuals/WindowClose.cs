using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowClose : MonoBehaviour
{
	// Start is called before the first frame update
	public void CloseWindow()
	{
		Destroy(gameObject);
	}
}
