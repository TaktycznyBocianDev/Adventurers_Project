using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputIntError : MonoBehaviour
{
    public Image errorImage;
    public TMP_InputField inputField;

    public void OnChangeCheckValueIfParsable()
    {
        if (!int.TryParse(inputField.text, out int result))
        {
            inputField.text = "";
            errorImage.gameObject.SetActive(true);
        }
    }
}
