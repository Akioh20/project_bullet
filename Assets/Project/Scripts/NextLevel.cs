using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene(); //AGAFA LA ESCENA ACTIVA
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Character")
        {
            if(scene.name == "Intro_Level1")
            {
                Debug.Log("Vaig al Intro_Lvl2");
                SceneManager.LoadScene("Intro_Level2");
            }
            else if (scene.name == "Intro_Level2")
            {
                SceneManager.LoadScene("Intro_Level3");
            }

        }
        
    }

}
