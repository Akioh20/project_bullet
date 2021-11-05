using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            if (Physics2D.OverlapCircle(mousePos, 0.05f) == GetComponent<Collider2D>())
            {
                Debug.Log("Clicked collider");
            }
        }
    }

    private void FixedUpdate()
    {
        
    }
}
