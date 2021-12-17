using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    int zoom = 20;
    int normal = 60;
    float smooth = 5; //this will make the transition not so abrupt

    private bool isZoomed;

    public void bZoom()
    {
        //this tell the program that when the player collides, the variable must be opposite as what is set in the init
        isZoomed = !isZoomed;
    }

    public void ControlCamera()
    {
        if (isZoomed)
        {
            //the boolean is true, will make the zoom
            gameObject.GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            //if not it will return to normal
            gameObject.GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
        }
    }
}
