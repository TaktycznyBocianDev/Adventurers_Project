using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{

    public string imie;
    public string koncepcja;

    public string sila;
    public string zrecznosc;
    public string umysl;

    public string wytrzymalosc;
    public string heroizm;
    public string atak;
    public string obrona;

    public string skills;
    public string eq;

    public string notes;
    public string story;

    public string PD;

    public Character(string imie, string koncepcja, string sila, string zrecznosc, string umysl, string wytrzymalosc, string heroizm, string atak, string obrona, string skills, string eq, string notes, string story, string pD)
    {
        this.imie = imie;
        this.koncepcja = koncepcja;
        this.sila = sila;
        this.zrecznosc = zrecznosc;
        this.umysl = umysl;
        this.wytrzymalosc = wytrzymalosc;
        this.heroizm = heroizm;
        this.atak = atak;
        this.obrona = obrona;
        this.skills = skills;
        this.eq = eq;
        this.notes = notes;
        this.story = story;
        PD = pD;
    }
}
