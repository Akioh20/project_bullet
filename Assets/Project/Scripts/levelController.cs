using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    public Canvas mRetry;
    //public Panel mRetry;
    //public Panel mWin;

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
        bool finished = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            finished &= enemies[i] == null;
        }
        if (finished)
            Win();
    }
}
