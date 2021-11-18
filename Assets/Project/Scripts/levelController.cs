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
        
    }

    public void Win()
    {

    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_1", LoadSceneMode.Single);
    }

    public void EnemyArray()
    {
        if (enemies.Length == 0)
        {
            Time.timeScale = 0f;
            Debug.Log("Has guanyat");
            //FALTA ACABAR
        }
    }

    //Necesitariem una funcio que registres toooots els enemicss en un array i els anes borrant (del arrai, que no de de la escena)
    //Aixo ens ajudaria a dir, vale, doncs salta a Win o Retry

    /*public void EnemyArray(GameObject enemy)
    {
        //FALTA BORRAR ELS ESPAIS DEL ARRAY QUAN UN ENEMIC SE'N VA A LA PUTA

        
        if(enemy == enemies[0])
        {
            Debug.Log("Enemy name: " + enemy.gameObject.name);
            Destroy(enemies[0].gameObject);
        }
        if (enemy == enemies[1])
        {
            Debug.Log("Enemy name: " + enemy.gameObject.name);
            Destroy(enemies[1].gameObject);
        }
        if (enemy == enemies[2])
        {
            Debug.Log("Enemy name: " + enemy.gameObject.name);
            Destroy(enemies[2].gameObject);
        }

        if (enemy == enemies[3])
        {
            Debug.Log("Enemy name: " + enemy.gameObject.name);
            Destroy(enemies[3].gameObject);
        }

        if (enemy == enemies[4])
        {
            Debug.Log("Enemy name: " + enemy.gameObject.name);
            Destroy(enemies[4].gameObject);
        }
        
    }*/
}
