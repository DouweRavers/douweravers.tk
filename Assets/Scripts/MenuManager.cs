using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    void Start()
    {
        if (Global.isMobile) {
            Screen.orientation = ScreenOrientation.Landscape;
            Screen.fullScreen = true;
        }
    }
}
