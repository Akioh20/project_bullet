using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    float currentZoom = 7f;
    float normal = 7f;

    private bool isZoomed;

    public Camera camera;

    public void SetZoom(float value)
    {
        currentZoom = value;
    }

    public void Update()
    { 
        currentZoom = Mathf.Lerp(currentZoom, normal, Time.deltaTime * 5f); //aquest millor petit 
        camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, currentZoom, Time.deltaTime * 100f);
    }
}
