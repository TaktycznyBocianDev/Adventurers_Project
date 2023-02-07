
## Adventurers! Manager Postaci

Aplikacja stanowi wsparcie dla graczy jako manager kart postaci oraz podręczny system rzutu kośćmi według mechaniki gry. Pozwala on na zapisywanie i modyfikowanie utworzonych bohaterów. Stworzona została jako projekt na studia. Ma także na celu obniżyć próg wejścia w świat gier RPG dla moich znajomych.


## Zdobyte doświadczenie:

- używanie plików .json w Unity
- operowanie systemem UI w Unity




## Features

- Manager kart postaci (save/load)
- Mechanika rzutu kośćmi wg zasad gry Adventurers!



## Manager kart postaci (save/load)

Najważniejszym elementem całego systemu jest mechanika pozwalająca zapisywać i wczytywać utworzone przez użytkownika karty postaci. Oparta jest o pliki typu .json.

![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen1Test.jpg?raw=true)
![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen4_50.jpg?raw=true)

Wszystko zaczyna się od gracza, który wprowadza dane. Następnie uruchamia się skrypt SaveToJSON, który wykorzystuje Builder. Ten zbiera informacje i tworzy obiekty typu Character. Tak przygotowany obiekt zostaje zmieniony na plik. Jego nazwa to imię bohatera.

```javascript
public class SaveToJSON : MonoBehaviour
{
    public void Save(Character character)
    {
        string json = JsonUtility.ToJson(character);
        Debug.Log(json);
        if (!Directory.Exists(Application.dataPath + "/Characters"))
        {
            Directory.CreateDirectory(Application.dataPath + "/Characters");
        }
        //Następnie sprawdzane są kolejne trzy opcje - czy istnieje taki plik? I czy
        //użytkownik chce nadpisać postać?
    }
}
```
System posiada dwa elementy, aby załadować gotową postać. EnableLoading zbiera wszystkie przygotowane postaci jako kolejne elementy na liście, a Load wczytuje przygotowaną wcześniej postać. Tu także pomaga Builder.

```javascript
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
```

Nauczenie się tej mechaniki było kluczowe dla projektu i sprawiło mi dużo radości gdy wszystko zaczęło działać płynnie i przyjemnie.

![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen3_50.jpg?raw=true)




## Mechanika rzutu kośćmi


Nie jest to moje pierwsze podejście do tego zagadnienia. Definitywnie jednak najbardziej udane i funkcjonalne.


![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen2_50.jpg?raw=true)


Cała mechanika rzutu kośćmi znajduje się w jednej klasie — RollDiceScript.
Najpierw wprowadzamy wartość testowanego współczynnika. Później wprowadzamy trudność testu — jaki jest minimalny wynik, który musimy uzyskać. Im więcej oczywiście — tym lepiej. System jest zabezpieczony, aby wartości te nie pozostały puste, co mogłoby prowadzić do błędów.


![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen5.jpg?raw=true)


Po naciśnięciu przycisku rzut uruchomiony zostaje generator liczb losowych, wynik zostaje wyświetlony i podany graczowi wraz z pokazaniem, czy udało mu się wygrać.
Dodatkowo jest możliwość zaznaczenia przewagi bądź porażki — rzuca się wtedy trzema kośćmi i wybiera z nich dwie odpowiednio lepsze bądź gorsze.


![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen8_50.jpg?raw=true)




## O Adventurures!


Adventurers to *"Prostota. Wszechstronne, łatwe do nauczenia zasady, dające dużą swobodę Graczom i Mistrzom Gry. Mieszczą się zaledwie na kilku stronach, podobnie przygody i settingi — wszystko w pełni funkcjonalne i gotowe do użycia na sesji!*
    (Adventurers! Umberto Pignatelli, wyd. FajneRPG, Kraków 2014)


Jest to system gwarantujący ogromną swobodę, ponieważ może być dostosowany do każdego świata, w jakim odbywać ma się akcja gry. Fantasy z krasnoludami? Mroczny RPG w zakładzie dla obłąkanych? Świat opanowany przez tosterodelfiny? W każdym z nich rozwiązania proponowane przez system zadziałają.


Jednocześnie ich wyjaśnienie to 4-5 minut z przerwą na kawę. Są trzy współczynniki: Siła, Zręczność, Umysł. Jeśli Twoja postać natknie się na jakąś trudność, aby sprawdzić, czy podołała — rzuć dwie sześciościenne kości i dodaj współczynnik. Jest więcej niż 7? Gratulacje. Mniej? No to zobaczmy, jak mocno oberwałeś...










