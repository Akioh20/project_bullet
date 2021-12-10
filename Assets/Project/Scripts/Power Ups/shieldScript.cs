using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour
{
    public ParticleSystem deathParticles = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(deathParticles, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            //collision.gameObject.GetComponent<bullet_controller>().Bounce(collision.contacts[0].normal);
            Destroy(this.gameObject);
        }
    }
}
