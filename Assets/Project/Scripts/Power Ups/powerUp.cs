using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("A Power Up has hit the Character");
        bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();

        if (col.gameObject.name == "Character" && gameObject.tag == "Fire")
        {
            bScript.pFire = true;
            Debug.Log("P-Fire caught");
            Destroy(gameObject);
        }

        if (col.gameObject.name == "Character" && gameObject.tag == "Shield")
        {
            /* L'ANTIGA PARET
            Debug.Log("Ara pots trencar una paret, pero nomes una");
            Destroy(gameObject);
            Destroy(col.gameObject);
            */

            bScript.pShield = true;
            Debug.Log("P-Shield caught");
            Destroy(gameObject);
        }
    }
}
