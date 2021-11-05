using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controller : MonoBehaviour
{
    public float movSpeed = 5f;
    public float turnRatio = 60f;
    Vector3 currentMovement = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ////// GET THE MOUSE IN WORLD SPACE
        Vector2 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        ////// GET THE DIRECTION TO THE MOUSE
        Vector3 targetMovement = mousePos - new Vector2(transform.position.x, transform.position.y);
        targetMovement = targetMovement.normalized;

        ////// ROTATION CHANGE
        float angle = Vector2.SignedAngle(currentMovement, targetMovement);
        //Angle that can be covered in 1 second
        float rotationInOneFrame = turnRatio * Time.deltaTime;
        angle = Mathf.Clamp(angle, -rotationInOneFrame, rotationInOneFrame);
        this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis(angle, Vector3.forward);
        currentMovement = this.transform.right;

        ////// POSITION CHANGE
        //Distance that can be covered in 1 second
        float movementInOneFrame = movSpeed * Time.deltaTime;

        this.transform.position += currentMovement.normalized * movementInOneFrame;


    }

    private void FixedUpdate()
    {
        
    }
}
