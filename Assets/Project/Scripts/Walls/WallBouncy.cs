using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBouncy : MonoBehaviour
{
    //////VARIABLES
    public ParticleSystem bounceParticles;

    int zoom = 20;
    int normal = 60;
    float smooth = 5; //this will make the transition not so abrupt

    private bool isZoomed;

    ZoomIn zoomIn;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(bounceParticles, new Vector3(collision.transform.position.x, collision.transform.position.y , collision.transform.position.z), Quaternion.identity);
            zoomIn.bZoom();
            //isZoomed = !isZoomed; //this tell the program that when the player collides, the variable must be opposite as what is set in the init
        }

        zoomIn.ControlCamera();

        /*
        if (isZoomed)
        {
            //the boolean is true, will make the zoom
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            //if not it will return to normal
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
        }
         */
    }

}
