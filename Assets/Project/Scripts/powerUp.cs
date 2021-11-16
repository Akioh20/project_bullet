using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Un Power Up ha tocat amb el Character");

        if (col.gameObject.name == "Character" && gameObject.tag == "Fire")
        {
            Debug.Log("UN POWER UP DE FOC HA TOCAT LA BALA, APLICA MÉS DANY.");
        }

        if (col.gameObject.name == "Character" && gameObject.tag == "Shield")
        {
            Debug.Log("UN POWER UP DE ESCUT HA TOCAT LA BALA, APLICA MÉS RESISTENCIA.");
        }
    }
}
