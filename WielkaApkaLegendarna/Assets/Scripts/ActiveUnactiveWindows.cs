using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveUnactiveWindows : MonoBehaviour
{

    [SerializeField] GameObject firstScreen;

    [SerializeField] GameObject secondScreen;


    public void ChangeScreens()
    {
        firstScreen.SetActive(false);
        secondScreen.SetActive(true);
    }
}
