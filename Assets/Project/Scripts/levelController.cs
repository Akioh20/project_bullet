using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    public Canvas mRetry;

    public GameObject[] enemies;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("Enemies array: " + enemies.Length);
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

        if (enemies.Length == 0)
        {
            Win();
        }
    }
}
