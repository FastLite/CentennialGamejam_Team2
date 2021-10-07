using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{

    public Canvas firstMenuUI;
    public Canvas mainUI;
    public Canvas controls;
    public bool escPress = false;
    public bool inMenu = false;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            escPress = true;
            MenuOpener();

            if (!inMenu)
            {
                inMenu = true;
            }
            else
            {
                inMenu = false;
            }
        }
    }

    void MenuOpener()
    {
        if (escPress && !inMenu)
        {
            firstMenuUI.gameObject.SetActive(true);
            mainUI.gameObject.SetActive(false);
            controls.gameObject.SetActive(false);
        }
        else if (escPress && inMenu)
        {
            firstMenuUI.gameObject.SetActive(false);
            mainUI.gameObject.SetActive(true);
            controls.gameObject.SetActive(false);
        }
        escPress = false;
    }

    public void DisableMenu(Canvas DisabledUI)
    {
        inMenu = false;
        DisabledUI.gameObject.SetActive(false);
    }

}
