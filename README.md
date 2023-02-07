*(For Polish version/Polska wersja językowa:* https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/README_PL.md)
## Adventurers! Manager Postaci

The application provides support for players as a character card manager and a handy dice throwing system according to game mechanics. It allows the user to save and modify created heroes. It was developed as a college project. Furthermore, it aims to lower the entry threshold into the world of RPG games for my friends.


## Gained Experience:

- using .json files in Unity
- operating the UI system in Unity


## Features

- Character card manager (save/load)
- Dice throwing mechanics according to Adventurers!'s rules



## Character card manager (save/load)

The most important part of the whole system is the mechanics that allow saving and loading the character cards created by the user. It is based on .json type files.

![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen1Test.jpg?raw=true)
![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen4_50.jpg?raw=true)

It all starts with the player entering the data. Then the SaveToJSON script goes to action, using Builder. This one collects information and creates a Character type object. The object thus prepared is turned into a file. Its name is the name of the character.

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
The system has two elements to load the prepared character. EnableLoading collects all the prepared characters as the list of items. Load, well, loads the previously prepared character. This is also where Builder helps.

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

Learning these mechanics was crucial to the project. It was a lot of fun when everything started working smoothly and pleasantly.

![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen3_50.jpg?raw=true)


## Dice throwing mechanics


This is not my first approach to this issue. Definitely, however, the most successful and functional.


![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen2_50.jpg?raw=true)


All the mechanics of dice throwing are in one class - RollDiceScript.
First, we enter the value of the coefficient to be tested. Later we enter the difficulty of the test - what is the minimum score we need to get. The more, of course - the better. The system is secured so that these values could not be blank, which could lead to errors.


![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen5.jpg?raw=true)


When the throw button is pressed, a random number generator is activated, the result is displayed and given to the player along with showing whether he has won.
In addition, there is an option to mark an advantage or disadvantage - you then roll three dice and choose from them two, respectively those better or worse.


![App Screenshot](https://github.com/TaktycznyBocianDev/Adventurers_Project/blob/main/ScreensForReadme/Screen8_50.jpg?raw=true)

## About Adventurures!

Adventurers are *"Simple. Comprehensive, easy-to-learn rules that give a lot of freedom to Players and Game Masters. They fit in just a few pages, likewise adventures and settings - all fully functional and ready to use in a session!*
    (Adventurers! Umberto Pignatelli, published by FajneRPG, Krakow 2014)


This is a system that guarantees great freedom, as it can be adapted to any world in which the game's action is to take place. Fantasy with dwarves? A dark RPG in an insane asylum? A world overrun by toaster-delphins? In each of them, the solutions proposed by the system will work.


At the same time, their explanation is 4–5 minutes with a coffee break. There are three coefficients: Strength, Dexterity, Mind. If your character encounters any difficulty, to see if it has coped - roll two six-sided dice and add a coefficient. Is it more than 7? Congratulations. Less? Well, let's see how hard you fail....










