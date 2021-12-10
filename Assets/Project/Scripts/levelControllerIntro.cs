using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelControllerIntro : MonoBehaviour
{
    public Canvas cRetry;
    Scene scene;

    bool cActive;

    public GameObject[] enemies;
    public GameObject bullet;

    void Start()
    {
        cRetry.GetComponent<Canvas>().enabled = false;
        cActive = false;

        scene = SceneManager.GetActiveScene(); //AGAFA LA ESCENA ACTIVA, NECESSARI PER EL RETRY
    }

    void Update()
    {
        EnemyArray();
        if (bullet = null)
        {
            activateCRetry();
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

    public void EnemyArray()
    {
        bool finished = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            finished &= enemies[i] == null;
        }
    }
}
