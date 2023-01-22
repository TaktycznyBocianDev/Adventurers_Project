using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToogleBehaviour : MonoBehaviour
{

    public Toggle toggle;
    public Toggle secondToggle;
    public Image dice3;

    public void ToggleBeh()
    {
        if (toggle.isOn)
        {
            secondToggle.isOn = false;
            dice3.gameObject.SetActive(true);
        }
        else
        {
            dice3.gameObject.SetActive(false);
        }
    }
}
