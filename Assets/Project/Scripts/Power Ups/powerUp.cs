using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public AudioSource getPowerUp;
    public AudioSource offPowerUp;

    void OnTriggerEnter2D(Collider2D col)
    {
        bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();

        if (col.gameObject.name == "Character" && gameObject.tag == "Fire")
        {
            getPowerUp.Play();
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
