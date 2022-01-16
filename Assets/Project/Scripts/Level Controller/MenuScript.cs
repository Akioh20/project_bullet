using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
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

    #region IntroLevels
    public void IntroLvl1()
    {
        SceneManager.LoadScene("Intro_Level1", LoadSceneMode.Single);
    }

    public void IntroLvl2()
    {
        SceneManager.LoadScene("Intro_Level2", LoadSceneMode.Single);
    }

    public void IntroLvl3()
    {
        SceneManager.LoadScene("Intro_Level3", LoadSceneMode.Single);
    }

    public void IntroLvl4()
    {
        SceneManager.LoadScene("Intro_Level4", LoadSceneMode.Single);
    }

    public void IntroLvl5()
    {
        SceneManager.LoadScene("Intro_Level5", LoadSceneMode.Single);
    }

    public void IntroLvl6()
    {
        SceneManager.LoadScene("Intro_Level6", LoadSceneMode.Single);
    }

    public void IntroLvl7()
    {
        SceneManager.LoadScene("Intro_Level7", LoadSceneMode.Single);
    }

    public void IntroLvl8()
    {
        SceneManager.LoadScene("Intro_Level8", LoadSceneMode.Single);
    }

    public void IntroLvl9()
    {
        SceneManager.LoadScene("Intro_Level9", LoadSceneMode.Single);
    }

    public void IntroLvl10()
    {
        SceneManager.LoadScene("Intro_Level10", LoadSceneMode.Single);
    }
    #endregion

    #region Levels
    public void GoToLvl11()
    {
        SceneManager.LoadScene("Level_11", LoadSceneMode.Single);
    }
    public void GoToLvl12()
    {
        SceneManager.LoadScene("Level_12", LoadSceneMode.Single);
    }

    public void GoToLvl13()
    {
        SceneManager.LoadScene("Level_13", LoadSceneMode.Single);
    }

    public void GoToLvl14()
    {
        SceneManager.LoadScene("Level_14", LoadSceneMode.Single);
    }

    public void GoToLvl15()
    {
        SceneManager.LoadScene("Level_15", LoadSceneMode.Single);
    }

    public void GoToLvl16()
    {
        SceneManager.LoadScene("Level_16", LoadSceneMode.Single);
    }

    public void GoToLvl17()
    {
        SceneManager.LoadScene("Level_17", LoadSceneMode.Single);
    }

    public void GoToLvl18()
    {
        SceneManager.LoadScene("Level_18", LoadSceneMode.Single);
    }

    public void GoToLvl19()
    {
        SceneManager.LoadScene("Level_19", LoadSceneMode.Single);
    }

    public void GoToLvl20()
    {
        SceneManager.LoadScene("Level_20", LoadSceneMode.Single);
    }

    public void GoToLvl21()
    {
        SceneManager.LoadScene("Level_21", LoadSceneMode.Single);
    }

    public void GoToLvl22()
    {
        SceneManager.LoadScene("Level_22", LoadSceneMode.Single);
    }

    public void GoToLvl23()
    {
        SceneManager.LoadScene("Level_23", LoadSceneMode.Single);
    }

    public void GoToLvl24()
    {
        SceneManager.LoadScene("Level_24", LoadSceneMode.Single);
    }

    public void GoToLvl25()
    {
        SceneManager.LoadScene("Level_25", LoadSceneMode.Single);
    }
    #endregion
}
