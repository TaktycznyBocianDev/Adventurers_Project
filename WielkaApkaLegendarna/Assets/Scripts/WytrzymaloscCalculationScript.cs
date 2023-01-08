using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WytrzymaloscCalculationScript : MonoBehaviour
{
    [SerializeField] TMP_Text wytTxt;

    [SerializeField] TMP_InputField silaTxt;

    [SerializeField] TMP_InputField zrecznoscTxt;

    public void onValueChange()
    {
        bool orangeLight = false;
        bool greenLight = false;

        int sila = 0;
        int zrecznosc = 0;
        int wytrzymalosc = 0;

        if (int.TryParse(silaTxt.text, out int silaResult) && silaTxt.text != null)
        {
            orangeLight = true;
            sila = silaResult;
        }
        if (int.TryParse(zrecznoscTxt.text, out int zrecznoscResult) && zrecznoscTxt.text != null)
        {
            greenLight = true;
            zrecznosc = zrecznoscResult;
        }

        if (orangeLight && greenLight)
        {
            wytrzymalosc = sila + zrecznosc + 3;
        }

        wytTxt.text = wytrzymalosc.ToString();
    }
}
