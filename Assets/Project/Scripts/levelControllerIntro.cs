using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelControllerIntro : MonoBehaviour
{
    public Canvas cRetry;
    public Canvas cPause;
    Scene scene;

    bool cActive;
    bool pActive;

    public float timetoReturn = 5f;

    public GameObject[] enemies;
    public GameObject bullet;

    void Start()
    {
        cRetry.GetComponent<Canvas>().enabled = false;
        cActive = false;

        cPause.GetComponent<Canvas>().enabled = false;
        pActive = false;

        scene = SceneManager.GetActiveScene(); //AGAFA LA ESCENA ACTIVA, NECESSARI PER EL RETRY
    }

    void Update()
    {
        EnemyArray();
        if (bullet = null)
        {
            activateCRetry();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            activeCPause();
        }
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    /*--TOT CANVAS RETRY--*/
    public void activateCRetry()
    {
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


    /*--TOT CANVAS PAUSE--*/

    public void activeCPause()
    {
        Debug.Log("Ara aqui faig magia");
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

    /*--OBSERVAR QUANTS ENEMICS QUEDEN--*/
    public void EnemyArray()
    {
        bool finished = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            finished &= enemies[i] == null;
        }
    }

    
}
