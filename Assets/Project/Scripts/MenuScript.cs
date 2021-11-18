using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public Canvas menuEnter;
    public Canvas menuSelect;
    public Canvas menuLevel;
    public Canvas menuOptions;


    void Start()
    {
        menuSelect.GetComponent<Canvas>().enabled = false;
        menuLevel.GetComponent<Canvas>().enabled = false;
        menuOptions.GetComponent<Canvas>().enabled = false;

        menuEnter.GetComponent<Canvas>().enabled = true;
    }

    public void GoToSelect()
    {
        menuEnter.GetComponent<Canvas>().enabled = false;
        menuLevel.GetComponent<Canvas>().enabled = false;
        menuOptions.GetComponent<Canvas>().enabled = false;

        menuSelect.GetComponent<Canvas>().enabled = true;
    }

    public void GoToLevel()
    {
        menuEnter.GetComponent<Canvas>().enabled = false;
        menuSelect.GetComponent<Canvas>().enabled = false;
        menuOptions.GetComponent<Canvas>().enabled = false;

        menuLevel.GetComponent<Canvas>().enabled = true;
    }

    public void GoToOptions()
    {
        menuEnter.GetComponent<Canvas>().enabled = false;
        menuLevel.GetComponent<Canvas>().enabled = false;
        menuSelect.GetComponent<Canvas>().enabled = false;

        menuOptions.GetComponent<Canvas>().enabled = true;
    }

    public void ExitOnClick()
    {
        Debug.Log("Adeeeu");
        Application.Quit();
    }

    public void GoToDemo()
    {
        Debug.Log("Salta a la escena de la presentacio");
        SceneManager.LoadScene("Level_1", LoadSceneMode.Single);
    }

}
