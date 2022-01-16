using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Camera mainCam;
    float shakeAmount = 0.5f;
    
    void Awake()
    {
        if(mainCam == null)
        {
            mainCam = Camera.main;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Shake(1, 2);
        }
    }

    //A function to make the shake in order not to call everytime the 2 functions downwards
    public void Shake(float amt, float length)
    {
        shakeAmount = amt;

        //The shake loop 
        InvokeRepeating("DoShake", 0, 0.01f);
        Invoke("StopShake", length);
    }
        void DoShake()
        {
            if(shakeAmount > 0)
        {
            //The vector will store the position of the main camera
            Vector3 camPos = mainCam.transform.position;

            float offsetX = Random.value * shakeAmount * 2 - shakeAmount;
            float offsetAmtY = Random.value * shakeAmount * 2 - shakeAmount;
            camPos.x += offsetX;
            camPos.x += offsetAmtY;

            mainCam.transform.position = camPos;
        }
        }

        void StopShake()
        {
            CancelInvoke("DoShake");
            //This we're going to make it in order that doesn't conflict with our camera following
            //The local position of the cam will be set equal to 0,0,0
            mainCam.transform.localPosition = Vector3.zero;
        }
}
