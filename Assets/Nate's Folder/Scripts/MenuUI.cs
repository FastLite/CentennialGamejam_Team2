using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{

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
        ActiveUI.gameObject.SetActive(true);
    }
}
