using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    public ParticleSystem deathParticles = null;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && gameObject.tag == "SpecialWall")
        {
            bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();

            if (bScript.pFire)
            {
                Instantiate(deathParticles, new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y, col.gameObject.transform.position.z), Quaternion.identity);
                Destroy(gameObject);
                bScript.pFire = false;
            }
            else
            {
                //FALTA AÑADIR EL REBOTE
                Destroy(gameObject);
                Debug.Log("deberías rebotar bro");
                Instantiate(deathParticles, new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y, col.gameObject.transform.position.z), Quaternion.identity);
                //Destroy(col.gameObject);
            }
            
        }
    }
}
