using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    public Canvas mRetry;

    public GameObject[] enemies;
    public GameObject bullet;

    void Update()
    {
        EnemyArray();
    }

    public void Win()
    {
        Time.timeScale = 0f;
        Debug.Log("Has guanyat");
        //aqui llavors actives canvas i el empty de win 
    }
    
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_1", LoadSceneMode.Single);
    }

    public void EnemyArray()
    {
        //Necesitariem una funcio que registres toooots els enemicss en un array i els anes borrant (del array, que no de de la escena)
        //------------ES BORREN DE LA ESCENA DES DE L'SCRIPT ENEMY
        //Aixo ens ajudaria a dir, vale, doncs salta a Win o Retry
        bool finished = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            finished &= enemies[i] == null;
        }
        if (finished)
            Win();
    }
}
