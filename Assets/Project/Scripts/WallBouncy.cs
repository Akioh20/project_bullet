using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBouncy : MonoBehaviour
{
    public ParticleSystem bounceParticles = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(bounceParticles, new Vector3(collision.transform.position.x, collision.transform.position.y , collision.transform.position.z), Quaternion.identity);
        }
    }
}
