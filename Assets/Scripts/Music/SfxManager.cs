using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioSource Click;

    public static SfxManager Instance;

    private void Awake() {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        // DontDestoyOnLoad(this);
    }

    public void PlayClick() {
        Click.Play();
    }
}
