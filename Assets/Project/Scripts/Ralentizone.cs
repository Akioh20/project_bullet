using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ralentizone : MonoBehaviour
{
    public GameObject ralentizone;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.name == "Character" && gameObject.tag == "Ralentizone")
        {
            bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();
            bScript.turnRatio = 350f;
            Debug.Log("Estic ralentitzat");
            Time.timeScale = 0.2f;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.name == "Character")
        {
            bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();
            bScript.turnRatio = 200f;
            Time.timeScale = 1f;
        }
    }
}