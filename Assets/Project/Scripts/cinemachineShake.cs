<<<<<<< Updated upstream:Assets/Project/Scripts/cinemachineShake.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinemachineShake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
=======
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

    private void Awake()
    {
        Instance = this;
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void ShakeCamera(float intensity, float time)
    {
        //To set the amplitude
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = 
            cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        //Here we modified the amplitude gain with the intensity
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
        //The time that the camera will be shaking
        shakeTimer = time;
    }

    private void Update()
    {   //This will check if the variable is higher than 0 or lower and equal to zero
        //If it's higher than zero, the variable will enter in the first if
        if(shakeTimer > 0)
        {
            //And here, the variable is going to be decrease as time goes by
            shakeTimer -= Time.deltaTime;

            //The variable is lower or equal to zero
            if(shakeTimer <= 0f)
            {
                //Time over
                //In this moment, we will set the amplitude to zero
                CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
                    cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
            }
        }
    }
}
>>>>>>> Stashed changes:Assets/cinemachineShake.cs
