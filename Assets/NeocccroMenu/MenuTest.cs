using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTest : MonoBehaviour
{
    bool win = true;

    Menu menu;

    private void Start()
    {
        menu = GetComponent<Menu>();
    }

    public void Test()
    {
        if(win)
        {
            menu.Win();
        }
        else
        {
            menu.Lose();
        }
        win = !win;
    }
}
