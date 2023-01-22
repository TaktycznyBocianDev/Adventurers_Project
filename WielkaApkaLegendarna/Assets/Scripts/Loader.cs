using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;


public class Loader : MonoBehaviour
{

    public Builder builder;

    public void LoadCharacterFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/Characters/" + gameObject.GetComponentInChildren<TMP_Text>().text + ".json");
        Character character = JsonUtility.FromJson<Character>(json);

        builder.BuildCharacter(character);

    }


}


