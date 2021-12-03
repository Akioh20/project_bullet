using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject portalFinal;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Un portal ha tocat amb el Character");

        if(col.gameObject.name == "Character" && gameObject.tag == "PortalEnt")
        {
            Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            col.gameObject.transform.position = portalFinal.transform.position;


            //FindObjectOfType<audioManager>().Play("BounceSound");
        }

        if (col.gameObject.name == "Character" && gameObject.tag == "PortalFin")
        {
            Debug.Log("NOOO! PER AQUEST PORTAL SURTS");
            //AQUI HI PODRIA HABER UN SOROLL ROLLO REBOT
        }
    }
}
