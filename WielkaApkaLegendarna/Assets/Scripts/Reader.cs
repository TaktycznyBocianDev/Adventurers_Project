using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reader : MonoBehaviour
{
    public TMP_InputField imie;
    public TMP_InputField koncept;
    public TMP_InputField sila;
    public TMP_InputField zrecznosc;
    public TMP_InputField umysl;
    public TMP_InputField wyt;
    public TMP_InputField her;
    public TMP_InputField atak;
    public TMP_InputField obrona;
    public TMP_InputField um;
    public TMP_InputField sprzet;
    public TMP_InputField notatki;
    public TMP_InputField historia;
    public TMP_InputField pD;

    public Character ReadCharacter()
    {
        Character character = 
            new Character(
                imie.text, 
                koncept.text,
                sila.text,
                zrecznosc.text,
                umysl.text,
                wyt.text,
                her.text,
                atak.text,
                obrona.text,
                um.text,
                sprzet.text,
                notatki.text,
                historia.text,
                pD.text
                );

        return character;

    }
}
