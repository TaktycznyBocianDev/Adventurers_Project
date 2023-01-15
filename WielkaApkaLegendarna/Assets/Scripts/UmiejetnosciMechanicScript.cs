using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiejetnosciMechanicScript : MonoBehaviour
{

    [SerializeField] GameObject littleUmTab;
    [SerializeField] GameObject littleGrid;

    [SerializeField] GameObject bigUmTab;
    [SerializeField] GameObject bigGrid;

    

    public void ReceiveOrDetailed(UmiejetnosciTemplate umiejetnoscRecived, bool deleating)
    {
        if (!deleating)
        {
            ReceiveUmiejetnosc(umiejetnoscRecived);
        }
        else
        {
            DeleteUmiejetnosc(umiejetnoscRecived);
        }
    }

    public void ReceiveUmiejetnosc(UmiejetnosciTemplate umiejetnoscRecived)
    {

        GameObject newTab = Instantiate(littleUmTab);
        newTab.transform.SetParent(littleGrid.transform, true);
        newTab.GetComponent<GridObjectBehaviours>().umiejetnosc = umiejetnoscRecived;

        //for (int i = 0; i < umiejetnoscTabs.Length; i++)
        //{
        //    if (umiejetnoscTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc == null)
        //    {
        //        umiejetnoscTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc = umiejetnosc;
        //        umiejetnoscTabs[i].SetActive(true);
        //        break;
        //    }
        //    else
        //    {
        //        Debug.Log("Nie ma wolnego Taba!");
        //    }
        //}
    }

    public void DeleteUmiejetnosc(UmiejetnosciTemplate umiejetnoscRecived)
    {
        GameObject newTab = Instantiate(bigUmTab);
        newTab.transform.parent = bigGrid.transform;
        newTab.GetComponent<GridObjectBehaviours>().umiejetnosc = umiejetnoscRecived;


        //umiejetnosc = umiejetnoscRecived;

        //for (int i = 0; i < umiejetnoscTabs.Length; i++)
        //{
        //    if (umiejetnosciGlowneTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc == null)
        //    {
        //        umiejetnosciGlowneTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc = umiejetnosc;
        //        break;
        //    }
        //    else
        //    {
        //        Debug.Log("Nie ma wolnego Taba!");
        //    }
        //}


    }
}
