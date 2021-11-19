using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Un Power Up ha tocat amb el Character");
        bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();

        if (col.gameObject.name == "Character" && gameObject.tag == "Fire")
        {
            bScript.pFire = true;
            Destroy(gameObject);

        }

        if (col.gameObject.name == "Character" && gameObject.tag == "Shield")
        {
            Debug.Log("Ara pots trencar una paret, pero nomes una");
            Destroy(gameObject);
            bScript.pShield = true;
        }
    }
}
