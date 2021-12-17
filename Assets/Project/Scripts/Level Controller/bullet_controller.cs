using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bullet_controller : MonoBehaviour
{
    #region Public variables
    public float movSpeed = 12f;
    public float turnRatio = 200f;
    public Rigidbody2D rb;
    public Canvas cRetry;
    public bool pFire;
    public bool pShield;
    #endregion

    private int counter = 0;
    public ParticleSystem deathParticles = null;
    Vector3 currentMovement = Vector3.right;
    
    void Start()
    {
        cRetry.GetComponent<Canvas>().enabled = false;
        pFire = false;
        pShield = false;
        Time.timeScale = 0f;
    }

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


        //EN CAP MOMENT ESTEM FENT SERVIR LA VARIABLE COUNTER. S
        //Debug.Log("Counter: " + counter);

        if (Input.GetMouseButtonDown(0) && counter == 0)
        {
            ResetBullet();
        }

        if (Input.GetMouseButtonDown(1))
        {
            movSpeed = 8f;
        }

        if (Input.GetMouseButtonUp(1))
        {
            movSpeed = 6f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bouncy"))
        {
            Bounce(collision.contacts[0].normal);

            //////For the moment, we're not going to use it
            //Set the intensity of the shake and the total time that it will shake
            //cinemachineShake.Instance.ShakeCamera(4f, 0.1f);
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            if (pShield)
            {
                //If u have the powerUp Shield, you can collide to a normal wall, and the powerUp dissapear
                pShield = false;

                //In order, than when it collides, it bounces in the other way
                Bounce(collision.contacts[0].normal);

                Debug.Log("YOU DON'T HAVE THE POWER UP");
                Debug.Log("POWER UP SHIELD: " + pShield);
            }
            else
            {
                //We make a play of the particles system in the position where the character dies
                Instantiate(deathParticles, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
              
                //If u don't have the powerUp Shield, you die
                Destroy(this.gameObject);
                Destroy(Camera.main.gameObject.GetComponent<cameraFollow>());
                cRetry.GetComponent<Canvas>().enabled = true;
                Time.timeScale = 0f;
            }
        }
    }

    public void Bounce(Vector3 normal)
    {
        //Change the mov direction
        currentMovement = normal * currentMovement.magnitude;
        //Change the angle
        this.transform.right = normal;
        this.transform.rotation = Quaternion.Euler(0f, 0f, this.transform.rotation.eulerAngles.z);
        Time.timeScale = 0.09f;
        Invoke("ResetTimeScale", 0.05f);
    }

    public void ResetTimeScale()
    {
        Time.timeScale = 1f;
    }

    public void ResetBullet()
    {
            Debug.Log("START");
            Time.timeScale = 1f;
            counter += 1;
    }
}