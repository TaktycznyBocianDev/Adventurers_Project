using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void OpenKartePostaci()
    {
        SceneManager.LoadScene(0);
    }
    public void OpenMainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenRzuty()
    {
        SceneManager.LoadScene(2);
    }

}
