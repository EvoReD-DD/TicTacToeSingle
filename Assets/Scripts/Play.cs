using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject gameModeSingle;
    [SerializeField] GameMode gameMode;
    [SerializeField] GameObject background;
    [SerializeField] Camera camera;
    
    public void Playing()
    {
        menu.SetActive(false);
        if (gameMode.Mode3DGame == false)
        {
            gameModeSingle.SetActive(true);
        }
        else
        {
            gameModeSingle.SetActive(true);
            background.SetActive(false);
            camera.orthographic = false;
            camera.transform.position = new Vector3(536, 1128, -1465);
            camera.fieldOfView = 85;
            camera.farClipPlane = 2000;
        }
    }
}
