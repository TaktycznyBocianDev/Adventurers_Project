using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class DeleteCharacter : MonoBehaviour
{
    public TMP_Text jsonFileNameText;
    public Button mainButtonGrid;

    public void DeleteFile()
    {
        string jsonFileName = jsonFileNameText.text + ".json";
        string path = Path.Combine(Application.dataPath + "/Characters/", jsonFileName);
        if (File.Exists(path))
        {
            File.Delete(path);
            Debug.Log(jsonFileName + " has been deleted.");
            mainButtonGrid.gameObject.SetActive(false);
            
        }
        else
        {
            Debug.LogError(jsonFileName + " not found.");
        }
    }
}