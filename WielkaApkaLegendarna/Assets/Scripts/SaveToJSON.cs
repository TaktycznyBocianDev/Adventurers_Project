using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveToJSON : MonoBehaviour
{
    [SerializeField] Reader reader;

    public void SaveToFile()
    {

        Save(reader.ReadCharacter());
    }

    public void Save(Character character)
    {
        string json = JsonUtility.ToJson(character);
        Debug.Log(json);

        if (!Directory.Exists(Application.dataPath + "/Characters"))
        {
            Directory.CreateDirectory(Application.dataPath + "/Characters");
        }
        File.WriteAllText(Application.dataPath + "/Characters" + "/" + character.imie + ".json", json);

    }
}
