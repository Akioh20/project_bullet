using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBouncy : MonoBehaviour
{
    //////VARIABLES
    public ParticleSystem bounceParticles;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(bounceParticles, new Vector3(collision.transform.position.x, collision.transform.position.y , collision.transform.position.z), Quaternion.identity);
            Camera.main.GetComponent<ZoomIn>().SetZoom(4f); //Zoom Camera
        }
    }
}
