using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridObjectBehaviours : MonoBehaviour
{
    [SerializeField] bool small;

    public UmiejetnosciTemplate umiejetnosc;

    [SerializeField] TMP_Text description;

    private void Awake()
    {
        ChangeText();  
    }

    public void ChangeText()
    {
        if (umiejetnosc != null)
        {
            if (!small)
            {
                description.text = umiejetnosc.skillName + "\n" + umiejetnosc.description;
            }
            else
            {
                description.text = umiejetnosc.skillName;
            }
        }
    }

}
