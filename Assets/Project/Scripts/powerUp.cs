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
            Destroy(gameObject);

            //AQUI DISCUTIR SI UNA BALA POT TENIR MES D'UN POWER UP I COM HO FEM

            //UN POWER UP TE TEMPS?
            //TEMPS PER AGAFAR-LO O S'ACTIVA DESPRES DE AGAFAR EL PU?

            //UN POWER UP TE UNA SOLA BONIFICACIO?

            //PARLAR SOBRE ELS POWER UPS

            //DESTRUIR SERA MES EFECTIU X EL RENDIMENT
        }

        if (col.gameObject.name == "Character" && gameObject.tag == "Shield")
        {
            Debug.Log("UN POWER UP DE ESCUT HA TOCAT LA BALA, APLICA MÉS RESISTENCIA.");
            Destroy(gameObject);
        }
    }
}
