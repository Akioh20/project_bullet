using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBouncy : MonoBehaviour
{
    //////VARIABLES
    public Camera cam;
    public float zoomMultiplier = 2;
    public float defaultFov = 90;
    public float zoomDuration = 0.01f;
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
            ZoomCamera(defaultFov / zoomMultiplier);
        }
        else if (cam.fieldOfView != defaultFov)
        {
            ZoomCamera(defaultFov);
        }
    }

    void ZoomCamera(float target)
    {
        float angle = Mathf.Abs((defaultFov / zoomMultiplier) - defaultFov);
        cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, angle / zoomDuration * Time.deltaTime);
    }
}