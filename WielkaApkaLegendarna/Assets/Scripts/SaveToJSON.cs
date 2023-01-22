using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SaveToJSON : MonoBehaviour
{
    [SerializeField] Builder builder;
    [SerializeField] bool overwiter;
    [SerializeField] Image overwriteWarning;

    public void SaveToFile()
    {

        Save(builder.ReadCharacter());
    }

    public void Save(Character character)
    {
        string json = JsonUtility.ToJson(character);
        Debug.Log(json);

        if (!Directory.Exists(Application.dataPath + "/Characters"))
        {
            Directory.CreateDirectory(Application.dataPath + "/Characters");
        }

        if (File.Exists(Application.dataPath + "/Characters" + "/" + character.imie + ".json") && overwiter)
        {
            File.WriteAllText(Application.dataPath + "/Characters" + "/" + character.imie + ".json", json);
            overwriteWarning.gameObject.SetActive(false);
        }

        if (File.Exists(Application.dataPath + "/Characters" + "/" + character.imie + ".json") && !overwiter)
        {
            overwriteWarning.gameObject.SetActive(true);
        }      

        if (!File.Exists(Application.dataPath + "/Characters" + "/" + character.imie + ".json"))
        {
            File.WriteAllText(Application.dataPath + "/Characters" + "/" + character.imie + ".json", json);
        }


    }
}
