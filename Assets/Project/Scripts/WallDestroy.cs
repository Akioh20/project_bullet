using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    public ParticleSystem deathParticles = null;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
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
                //Vuelve a fallar el rebote, tan solo rebota por la parte de la derecha
                //bScript.Bounce(col.contacts[0].normal);
                Destroy(gameObject);
                Instantiate(deathParticles, new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y, col.gameObject.transform.position.z), Quaternion.identity);
            }
            
        }
    }
}