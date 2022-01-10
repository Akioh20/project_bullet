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
            else if (scene.name == "Intro_Level3")
            {
                SceneManager.LoadScene("Intro_Level4");
            }
            else if (scene.name == "Intro_Level4")
            {
                SceneManager.LoadScene("Intro_Level5");
            }
            else if (scene.name == "Intro_Level5")
            {
                SceneManager.LoadScene("Intro_Level6");
            }
            else if (scene.name == "Intro_Level6")
            {
                SceneManager.LoadScene("Intro_Level7");
            }
            else if (scene.name == "Intro_Level7")
            {
                SceneManager.LoadScene("Intro_Level8");
            }
            else if (scene.name == "Intro_Level8")
            {
                SceneManager.LoadScene("Intro_Level9");
            }
            else if (scene.name == "Intro_Level9")
            {
                SceneManager.LoadScene("Intro_Level10");
            }
            else if (scene.name == "Intro_Level10")
            {
                SceneManager.LoadScene("Level_1");
            }

        }
        
    }

}
