using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiejetnosciMechanicScript : MonoBehaviour
{

    [SerializeField] GameObject[] littleUmTabs;
    [SerializeField] GameObject[] bigUmTabs;



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



        for (int i = 0; i < littleUmTabs.Length; i++)
        {

            if (littleUmTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc == null && littleUmTabs[i].activeInHierarchy == false)
            {
                littleUmTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc = umiejetnoscRecived;
                littleUmTabs[i].GetComponent<GridObjectBehaviours>().ChangeText();
                littleUmTabs[i].SetActive(true);
                break;
            }
            else
            {
                Debug.Log("Nie ma wolnego Taba");
            }

        }

    }

    public void DeleteUmiejetnosc(UmiejetnosciTemplate umiejetnoscRecived)
    {


        for (int i = 0; i < bigUmTabs.Length; i++)
        {
            if (bigUmTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc == null && bigUmTabs[i].activeInHierarchy == false)
            {
                bigUmTabs[i].GetComponent<GridObjectBehaviours>().umiejetnosc = umiejetnoscRecived;
                bigUmTabs[i].GetComponent<GridObjectBehaviours>().ChangeText();
                bigUmTabs[i].SetActive(true);
                break;
            }
            else
            {
                Debug.Log("Nie ma wolnego Taba");
            }

        }
       

    }


}



