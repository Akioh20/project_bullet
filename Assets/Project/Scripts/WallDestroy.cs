using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && gameObject.tag == "SpecialWall")
        {
            //Agafo l'script de la bala i li dic que si 
            //te TRUE el POWER UP FIRE, destrueixi la paret
            bullet_controller bScript = col.gameObject.GetComponent<bullet_controller>();

            if (bScript.pFire)
            {
                Debug.Log("Aqui entro si el personatje te el pw FIRE");
                Destroy(gameObject);
            } 

            else Destroy(col.gameObject);

            
        }
    }
}
