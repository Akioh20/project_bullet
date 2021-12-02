using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    public Canvas cRetry;
    public Canvas cWin;

    Scene scene;

    bool cActive;

    public GameObject[] enemies;
    public GameObject bullet;

    void Start()
    {
        cRetry.GetComponent<Canvas>().enabled = false;
        cWin.GetComponent<Canvas>().enabled = false;
        cActive = false;

        scene = SceneManager.GetActiveScene(); //AGAFA LA ESCENA ACTIVA, NECESSARI PER EL RETRY
        
    }

    void Update()
    {
        EnemyArray();
    }

    /*--TOT CANVAS WIN--*/
    public void activateCWin()
    {
        //Time.timeScale = 0f;
        Debug.Log("Has guanyat");
        cWin.GetComponent<Canvas>().enabled = true;
        cActive = true;
        if (cActive)
        {
            Time.timeScale = 0f;
            Debug.Log("HE PARAT EL TEMPS");
        }
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*--NIVELLS CONCRETS--*/
    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
    }

    /*--TOT CANVAS RETRY--*/
    public void activateCRetry()
    {
        //Time.timeScale = 0f;
        Debug.Log("Has perdut");
        cRetry.GetComponent<Canvas>().enabled = true;
        cActive = true;
        if (cActive)
        {
            Time.timeScale = 0f;
            Debug.Log("HE PARAT EL TEMPS");
        }
    }

    public void bRetry()
    {
        SceneManager.LoadScene(scene.name);
    }

    /*--MIRA TOTA L'ESTONA X ENEMICS QUE QUEDEN--*/
    public void EnemyArray()
    {
        bool finished = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            finished &= enemies[i] == null;
        }
        if (finished)
            activateCWin();
    }
}
