using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ralentizone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name == "Character")
        {
            Debug.Log("In");
            bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();
            bScript.turnRatio = 350f;
            Debug.Log("Estic ralentitzat");
            Time.timeScale = 0.35f;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.name == "Character")
        {
            Debug.Log("Out");
            bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();
            bScript.turnRatio = 200f;
            Time.timeScale = 1f;
        }
    }
}