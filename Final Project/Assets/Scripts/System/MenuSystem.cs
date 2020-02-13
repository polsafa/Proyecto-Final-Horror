using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    public GameObject principlaCanvas;
    public GameObject SettingsCanvas;
    public GameObject buttonCharge;

  public void NewGame()
    {
        SceneManager.LoadSceneAsync("");
    }
    
    public void ChargeGame()
    {

    }

    public void OpenSettings()
    {
        principlaCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {

    }

    public void SaveGame()
    {

    }

    public void ReturnMenuPrincipal()
    {

        principlaCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
    }

    public void Update()
    {
        var fileName = "save.txt";
       
        if (File.Exists(fileName))
        {
            buttonCharge.SetActive(true);

        }
        else
        {
            buttonCharge.SetActive(false);

        }
    }
}

