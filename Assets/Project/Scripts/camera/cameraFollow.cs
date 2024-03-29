using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject follow;
    //public Vector2 minCamPos, maxCamPos;
    public float smoothTime;

    private Vector2 velocity;

    //Utilitzem el fixed update perque les fisiques es puguin fer cada segon en comptes de cada frame. Aixi no donar� problemes
    //depenent de la calitat del ordinador
    void Update()
    {
        //Emprem el SmoothDamp, que es una funci� de la llibrer�a Mathf, la cual fara que la camara segueixi el character
        //de forma que vaigue una mica retrasada, fent el moviment mes llisa, agradable
        if (follow == null)
            return;

        //float posX = Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smoothTime, 10000f, Time.deltaTime);
        //float posY = Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smoothTime, 10000f, Time.deltaTime);
        float posX = Mathf.Lerp(transform.position.x, follow.transform.position.x, 20.0f * Time.deltaTime);
        float posY = Mathf.Lerp(transform.position.y, follow.transform.position.y, 20.0f * Time.deltaTime);
        transform.position = new Vector3(posX, posY, transform.position.z);
       /* transform.position = new Vector3(
        Mathf.Clamp(posX, minCamPos.x, maxCamPos.x),
        Mathf.Clamp(posY, minCamPos.y, maxCamPos.y),
        transform.position.z);*/

        //this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(follow.transform.position.x, follow.transform.position.y, -10f), Time.deltaTime * 30f);

    }
}