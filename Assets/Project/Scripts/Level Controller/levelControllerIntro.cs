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

    public float timeToReturn = 5f;

    public GameObject[] enemies;
    public GameObject bullet;

    bullet_controller bScript;

    void Start()
    {
        cRetry.GetComponent<Canvas>().enabled = false;
        cActive = false;

        cPause.GetComponent<Canvas>().enabled = false;
        pActive = false;

        scene = SceneManager.GetActiveScene(); //AGAFA LA ESCENA ACTIVA, NECESSARI PER EL RETRY

        bScript = gameObject.GetComponent<bullet_controller>();
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
        cPause.GetComponent<Canvas>().enabled = true;
        pActive = true;
        if (pActive) Time.timeScale = 0f;
    }

    public void bReturnPause()
    {
        cPause.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1f;
        pActive = false;
        //AQUI FALTA EL CONTADOR ENRERRE, PERO NO PUC PERQUE DES DEL BUTTON... WAK
        //També podriem fer servir el bScript.ResetBullet()
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
