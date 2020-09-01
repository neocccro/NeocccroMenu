using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private menus startMenu;
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject winMenu;
    [SerializeField]
    private GameObject loseMenu;
    [SerializeField]
    private GameObject creditsMenu;

    private GameObject activeMenu;

    enum menus
    {
        main,
        win,
        lose,
        credits,
        none
    }
    
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(false);
        winMenu.SetActive(false);
        loseMenu.SetActive(false);
        creditsMenu.SetActive(false);
        OpenMenu(startMenu);
    }

    public void Main()
    {
        OpenMenu(menus.main);
    }

    public void Win()
    {
        OpenMenu(menus.win);
    }

    public void Lose()
    {
        OpenMenu(menus.lose);
    }

    public void Credits()
    {
        OpenMenu(menus.credits);
    }

    private void OpenMenu(menus menu)
    {
        if (activeMenu != null)
        {
            activeMenu.SetActive(false);
        }
        switch (menu)
        {
            case menus.main:
                activeMenu = mainMenu;
                break;
            case menus.win:
                activeMenu = winMenu;
                break;
            case menus.lose:
                activeMenu = loseMenu;
                break;
            case menus.credits:
                activeMenu = creditsMenu;
                break;
            case menus.none:
                break;
            default:
                Debug.Log("wot?");
                break;
        }
        activeMenu.SetActive(true);
    }

    public void OtherMenu(GameObject menu)
    {
        if (activeMenu != null)
        {
            activeMenu.SetActive(false);
        }
        activeMenu = menu;
        activeMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
