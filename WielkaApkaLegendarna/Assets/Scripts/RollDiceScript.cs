using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollDiceScript : MonoBehaviour
{


    public TMP_InputField wspolczynnikInput;
    public TMP_InputField trudnoscInput;

    public TMP_Text kosc1, kosc2, kosc3;

    public Image sumaImage;
    public TMP_Text sumaTxt;

    public Toggle przewaga, przeszkoda;

    public Image krytycznyImg;
    public TMP_Text krytycznyTekst;

    public Image errorImage;


    public void RollDices()
    {

        if (trudnoscInput.text == "" || wspolczynnikInput.text == "")
        {
            errorImage.gameObject.SetActive(true);           
        }
        else
        {
            if (!(przewaga.isOn || przeszkoda.isOn))
            {
                krytycznyImg.gameObject.SetActive(false);

                int roll = Random.Range(1, 7);
                int secondRoll = Random.Range(1, 7);
                int wspolczynnik = int.Parse(wspolczynnikInput.text);
                int trudnosc = int.Parse(trudnoscInput.text);

                kosc1.text = roll.ToString();
                kosc2.text = secondRoll.ToString();

                if (roll == 6 && secondRoll == 6)
                {
                    krytycznyImg.gameObject.SetActive(true);
                    krytycznyImg.color = Color.green;
                    krytycznyTekst.text = "KRYTYCZNY SUKCES!";
                }

                if (roll == 1 && secondRoll == 1)
                {
                    krytycznyImg.gameObject.SetActive(true);
                    krytycznyImg.color = Color.red;
                    krytycznyTekst.text = "KRYTYCZNA PORA¯KA!";
                }

                if (wspolczynnik + roll + secondRoll >= trudnosc)
                {
                    sumaImage.color = Color.green;
                    sumaTxt.text = (wspolczynnik + roll + secondRoll).ToString();
                    Debug.Log("Zwyciêstwo");
                }
                else
                {
                    sumaImage.color = Color.red;
                    sumaTxt.text = (wspolczynnik + roll + secondRoll).ToString();
                    Debug.Log("xD Loooool hahahaha");
                }

            }

            if (przewaga.isOn)
            {
                krytycznyImg.gameObject.SetActive(false);

                int roll = Random.Range(1, 7);
                int secondRoll = Random.Range(1, 7);
                int thirdRoll = Random.Range(1, 7);
                int wspolczynnik = int.Parse(wspolczynnikInput.text);
                int trudnosc = int.Parse(trudnoscInput.text);

                kosc1.text = roll.ToString();
                kosc2.text = secondRoll.ToString();
                kosc3.text = thirdRoll.ToString();

                int tmp;
                if (roll > secondRoll)
                {
                    tmp = roll;
                    roll = secondRoll;
                    secondRoll = tmp;
                }
                if (secondRoll > thirdRoll)
                {
                    tmp = secondRoll;
                    secondRoll = thirdRoll;
                    thirdRoll = tmp;
                }
                if (roll > secondRoll)
                {
                    tmp = roll;
                    roll = secondRoll;
                    secondRoll = tmp;
                }

                Debug.Log(roll.ToString() + secondRoll.ToString() + thirdRoll.ToString());

                if (secondRoll == 6 && thirdRoll == 6)
                {
                    krytycznyImg.gameObject.SetActive(true);
                    krytycznyImg.color = Color.green;
                    krytycznyTekst.text = "KRYTYCZNY SUKCES!";
                }

                if (secondRoll == 1 && thirdRoll == 1)
                {
                    krytycznyImg.gameObject.SetActive(true);
                    krytycznyImg.color = Color.red;
                    krytycznyTekst.text = "KRYTYCZNA PORA¯KA!";
                }

                if (wspolczynnik + thirdRoll + secondRoll >= trudnosc)
                {
                    sumaImage.color = Color.green;
                    sumaTxt.text = (wspolczynnik + thirdRoll + secondRoll).ToString();
                    Debug.Log("Zwyciêstwo");
                }
                else
                {
                    sumaImage.color = Color.red;
                    sumaTxt.text = (wspolczynnik + thirdRoll + secondRoll).ToString();
                    Debug.Log("xD Loooool hahahaha");
                }

            }

            if (przeszkoda.isOn)
            {
                krytycznyImg.gameObject.SetActive(false);

                int roll = Random.Range(1, 7);
                int secondRoll = Random.Range(1, 7);
                int thirdRoll = Random.Range(1, 7);
                int wspolczynnik = int.Parse(wspolczynnikInput.text);
                int trudnosc = int.Parse(trudnoscInput.text);

                kosc1.text = roll.ToString();
                kosc2.text = secondRoll.ToString();
                kosc3.text = thirdRoll.ToString();

                int tmp;
                if (roll > secondRoll)
                {
                    tmp = roll;
                    roll = secondRoll;
                    secondRoll = tmp;
                }
                if (secondRoll > thirdRoll)
                {
                    tmp = secondRoll;
                    secondRoll = thirdRoll;
                    thirdRoll = tmp;
                }
                if (roll > secondRoll)
                {
                    tmp = roll;
                    roll = secondRoll;
                    secondRoll = tmp;
                }

                Debug.Log(roll.ToString() + secondRoll.ToString() + thirdRoll.ToString());

                if (roll == 6 && secondRoll == 6)
                {
                    krytycznyImg.gameObject.SetActive(true);
                    krytycznyImg.color = Color.green;
                    krytycznyTekst.text = "KRYTYCZNY SUKCES!";
                }

                if (roll == 1 && secondRoll == 1)
                {
                    krytycznyImg.gameObject.SetActive(true);
                    krytycznyImg.color = Color.red;
                    krytycznyTekst.text = "KRYTYCZNA PORA¯KA!";
                }

                if (wspolczynnik + roll + secondRoll >= trudnosc)
                {
                    sumaImage.color = Color.green;
                    sumaTxt.text = (wspolczynnik + roll + secondRoll).ToString();
                    Debug.Log("Zwyciêstwo");
                }
                else
                {
                    sumaImage.color = Color.red;
                    sumaTxt.text = (wspolczynnik + roll + secondRoll).ToString();
                    Debug.Log("xD Loooool hahahaha");
                }
            }
        }
    }
}
