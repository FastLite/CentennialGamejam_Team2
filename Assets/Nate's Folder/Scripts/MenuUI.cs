using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public GameObject player;
    public GameObject thirdPersonCam;

    public void ChangeSceen(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

   public void LeaveGame()
    {
        Application.Quit();
    }

   public void DisableMenu(Canvas DisabledUI)
    {
        DisabledUI.gameObject.SetActive(false);
    }

    public void ActiveMenu(Canvas ActiveUI)
    {
        if (player == null && thirdPersonCam == null)
        {
            ActiveUI.gameObject.SetActive(true);
        }
        else
        {
            player.GetComponent<ThirdPersonMovement>().enabled = true;
            player.GetComponent<TeleportPlayerToAlt>().enabled = true;
            thirdPersonCam.SetActive(true);
            ActiveUI.gameObject.SetActive(true);
        }
    }
}
