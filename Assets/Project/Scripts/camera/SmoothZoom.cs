using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class SmoothZoom : MonoBehaviour
{
    //////VARIABLES
    public Camera cam;
    public float zoomMultiplier = 2;
    public float defaultFov = 90;
    public float zoomDuration = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (collision.gameObject.CompareTag("Wall"))
        {
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

*/