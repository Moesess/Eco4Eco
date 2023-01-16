using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EcoGame {

    public class PlayButton : MonoBehaviour
    {
        public void OnClick()
        {
            SfxManager.sfxInstance.PlayClick();
        }
    }
}
