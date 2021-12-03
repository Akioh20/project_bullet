using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementZoom : MonoBehaviour
{
    public float zoomLevel;
    public Transform parentObject;

    // Start is called before the first frame update
    void Start()
    {
        // Limits the zoom to 30 units
        zoomLevel = Mathf.Clamp(zoomLevel, 0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = parentObject.position + (transform.forward * zoomLevel);
    }
}
