
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cinemachineShake : MonoBehaviour
{
    //Will make this instance in order to make this very easy to use
    public static cinemachineShake Instance { get; private set; }

    //private variables
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private float shakeTimer;
    private float startingIntensity;
    private float shakeTimerTotal;

    private void Awake()
    {
        Instance = this;
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void ShakeCamera(float intensity, float time)
    {
        //To set the amplitude
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = 
            cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        //Here we modified the amplitude gain with the intensity
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
        //Set the intensity
        startingIntensity = intensity;
        //Store the total time in the variable time
        shakeTimerTotal = time;
        //The time that the camera will be shaking
        shakeTimer = time;
    }

    private void Update()
    {   //This will check if the variable
        //If it's higher than zero, the variable will enter in the first if
        if (shakeTimer > 0)
        {
            //And here, the variable is going to be decrease as time goes by
            shakeTimer -= Time.deltaTime;
             //If he variable is lower or equal to zero
     
            //Time over
            //In this moment, we will set the amplitude to zero
            CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
              cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
            cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = Mathf.Lerp(startingIntensity, 0f, shakeTimer / shakeTimerTotal);
            }
        }
    }


