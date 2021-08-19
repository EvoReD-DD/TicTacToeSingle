using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public GameObject menu;
    public GameObject gameModeSingle;
    
    public void Playing()
    {
        menu.SetActive(false);
        gameModeSingle.SetActive(true);
    }
}
