using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject player;
    public GameObject thirdPersonCam;
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

            gameObject.GetComponent<MenuUI>().isPlayerInMenu(inMenu);
        }
    }

    void MenuOpener()
    {
        if (escPress && !inMenu)
        {
            firstMenuUI.gameObject.SetActive(true);
            mainUI.gameObject.SetActive(false);
            controls.gameObject.SetActive(false);
            player.GetComponent<ThirdPersonMovement>().enabled = false;
            player.GetComponent<TeleportPlayerToAlt>().enabled = false;
            thirdPersonCam.SetActive(false);
        }
        else if (escPress && inMenu)
        {
            firstMenuUI.gameObject.SetActive(false);
            mainUI.gameObject.SetActive(true);
            controls.gameObject.SetActive(false);
            player.GetComponent<ThirdPersonMovement>().enabled = true;
            player.GetComponent<TeleportPlayerToAlt>().enabled = true;
            thirdPersonCam.SetActive(true);
        }
        escPress = false;
    }

    public void DisableMenu(Canvas DisabledUI)
    {
        player.GetComponent<ThirdPersonMovement>().enabled = true;
        player.GetComponent<TeleportPlayerToAlt>().enabled = true;
        thirdPersonCam.SetActive(true);
        inMenu = false;
        gameObject.GetComponent<MenuUI>().isPlayerInMenu(inMenu);
        DisabledUI.gameObject.SetActive(false);
    }

}
