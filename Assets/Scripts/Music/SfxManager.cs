using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioSource Click;

    public static SfxManager sfxInstance;

    private void Awake() {
        if(sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxInstance = this;
        // DontDestoyOnLoad(this);
    }

    public void PlayClick() {
        Click.Play();
    }
}
