using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("I have been hit!");
        if(col.gameObject.tag == "Player" && gameObject.tag == "SpecialWall")
        {
            Debug.Log("The wall has been hit, destroyed it");
            Destroy(gameObject);
        }
    }
}
