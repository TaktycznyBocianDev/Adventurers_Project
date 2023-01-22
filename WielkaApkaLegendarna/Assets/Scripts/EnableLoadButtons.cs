using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class EnableLoadButtons : MonoBehaviour
{

    public Button[] charactersGrid;
    
    public void GetJsonNames()
    {
        string path = Application.dataPath + "/Characters/";
        string[] jsonFiles = Directory.GetFiles(path, "*.json");

        for (int i = 0; i < jsonFiles.Length; i++)
        {
            charactersGrid[i].GetComponentInChildren<TMP_Text>().text = Path.GetFileNameWithoutExtension(jsonFiles[i]);
            charactersGrid[i].gameObject.SetActive(true);

        }

        //foreach (string jsonFile in jsonFiles)
        //{
        //    string jsonFileName = Path.GetFileName(jsonFile);
        //    Debug.Log(jsonFileName);
        //}
    }
   



}
