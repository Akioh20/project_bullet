using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject portalEntrada;
    public GameObject portalFinal;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Un portal ha tocat amb el Character");

        if(col.gameObject.name == "Character" && gameObject.name == "PortalEntrant")
        {
            Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            col.gameObject.transform.position = portalFinal.transform.position;
        }

        if (col.gameObject.name == "Character" && gameObject.name == "PortalFin")
        {
            Debug.Log("NOOO! PER AQUEST PORTAL SURTS");
        }
    }
}
