using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowButtonsBehaviour : MonoBehaviour
{
    [SerializeField] GameObject gridPart;

    [SerializeField] GameObject target;
    
    [SerializeField] bool IsDelete;
    
    public void InitiateSequence()
    {
        UmiejetnosciTemplate umiejetnosc = GetComponentInParent<GridObjectBehaviours>().umiejetnosc;
        target.GetComponent<UmiejetnosciMechanicScript>().ReceiveOrDetailed(umiejetnosc, IsDelete);
        GetComponentInParent<GridObjectBehaviours>().umiejetnosc = null;
        gridPart.SetActive(false);


    }


}
