using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();

        if (col.gameObject.name == "Character" && gameObject.tag == "Fire")
        {
            bScript.pFire = true;
            Debug.Log("P-Fire caught");
            Destroy(gameObject);
        }

        if (col.gameObject.name == "Character" && gameObject.tag == "Shield")
        {
            bScript.pShield = true;
            Debug.Log("P-Shield caught");
            Destroy(gameObject);
        }
    }
}
