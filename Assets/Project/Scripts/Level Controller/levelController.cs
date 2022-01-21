using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    public Canvas cRetry;
    public Canvas cWin;
    public Canvas cPause;

    Scene scene;

    bool cActive;
    bool pActive;


    public GameObject[] enemies;
    public GameObject bullet;

    void Start()
    {
        FindObjectOfType<audioManager>().Play("BounceSound");

        cRetry.GetComponent<Canvas>().enabled = false;
        cWin.GetComponent<Canvas>().enabled = false;
        cActive = false;

        cPause.GetComponent<Canvas>().enabled = false;
        pActive = false;

        scene = SceneManager.GetActiveScene(); //AGAFA LA ESCENA ACTIVA, NECESSARI PER EL RETRY
    }

    void Update()
    {
        EnemyArray();
        if (bullet == null)
        {
            activateCRetry();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activeCPause();
        }
    }
    /*--NEXT LEVEL, BUILD INDEX--*/
    #region nextLevel
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    #endregion

    /*--ESCENES CONCRETES--*/
    #region Scenes

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level_4");
    }
    #endregion

    /*--TOT CANVAS WIN--*/
    #region cWin
    public void activateCWin()
    {
        cWin.GetComponent<Canvas>().enabled = true;
        cActive = true;
        if (cActive) Time.timeScale = 0f;

    }
    #endregion

    /*--TOT CANVAS RETRY--*/
    #region cRetry
    public void activateCRetry()
    {
        Debug.Log("Has perdut");
        cRetry.GetComponent<Canvas>().enabled = true;
        cActive = true;
        if (cActive) Time.timeScale = 0f;

    }

    public void bRetry()
    {
        SceneManager.LoadScene(scene.name);
    }
    #endregion

    /*--TOT CANVAS PAUSE--*/
    #region cPause
    public void activeCPause()
    {
        cPause.GetComponent<Canvas>().enabled = true;
        pActive = true;
        if (pActive) Time.timeScale = 0f;
    }

    public void bReturnPause()
    {
        cPause.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1f;
        pActive = false;
        //AQUI FALTA EL CONTADOR, PERO NO DESDE EL BOTO
    }
    #endregion

    /*--MIRA TOTA L'ESTONA X ENEMICS QUE QUEDEN--*/
    public void EnemyArray()
    {
        bool finished = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            finished &= enemies[i] == null;
        }
        if (finished) activateCWin();
    }
}
