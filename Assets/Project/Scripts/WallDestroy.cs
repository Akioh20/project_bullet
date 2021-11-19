using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && gameObject.tag == "SpecialWall")
        {
            bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();

            if (bScript.pFire)
            {
                Destroy(gameObject);
                bScript.pFire = false;
            } 
            else Destroy(col.gameObject);

            
        }
    }
}
