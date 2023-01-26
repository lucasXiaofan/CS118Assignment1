using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class DoorandMenu : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] Text buttonText;


    public void showOrHide()
    {
        print("called");
        if (MainMenu.activeInHierarchy)
        {
            buttonText.text = "Hide Menu";
            MainMenu.SetActive(false);
            buttonText.text = "Show Menu";
        }
        else if (!(MainMenu.activeInHierarchy))
        {
            buttonText.text = "Show Menu";
            MainMenu.SetActive(true);
            buttonText.text = "Hide Menu";
        }

    }
    public void quitgame()
    {
        print("quit Game");
        Application.Quit();
    }
}
