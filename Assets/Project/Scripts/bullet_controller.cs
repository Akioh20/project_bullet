using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controller : MonoBehaviour
{
    public float movSpeed = 12f;
    public float turnRatio = 450f;
    Vector3 currentMovement = Vector3.right;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.8f;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bouncy"))
        {
            //Change the mov direction
            currentMovement = collision.contacts[0].normal * currentMovement.magnitude;
            //Change the angle
            this.transform.right = collision.contacts[0].normal;
            this.transform.rotation = Quaternion.Euler(0f, 0f, this.transform.rotation.eulerAngles.z);
            Time.timeScale = 0.09f;
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Time.timeScale = 1f;
    }
}