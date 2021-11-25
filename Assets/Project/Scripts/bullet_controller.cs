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
    public Canvas menuRetry;
    public bool pFire;
    public bool pShield;
    #endregion
    public ParticleSystem deathParticles = null;
    Vector3 currentMovement = Vector3.right;
    
    void Start()
    {
        menuRetry.GetComponent<Canvas>().enabled = false;
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

        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CameraShake CamShake = collision.gameObject.GetComponent<CameraShake>();

        if (collision.gameObject.CompareTag("Bouncy"))
        {
            //CamShake.Shake(1, 2);
            Bounce(collision.contacts[0].normal);
        }
        
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (pShield)
            {
                //Si tens el powerUp Shield, et pots xocar contra una paret pero adeu siau powerUp
                pShield = false;
                Debug.Log("CUIDADO QUE JA NO TENS POWER UP");
                Debug.Log("POWER UP SHIELD: " + pShield);
            }
            else
            {
                //Fem play del sistema de particules al lloc on mor el personatje
                Instantiate(deathParticles, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                //Si no tens el powerUp Shield, adeu siau
                Destroy(this.gameObject);
                Destroy(Camera.main.gameObject.GetComponent<cameraFollow>());
                menuRetry.GetComponent<Canvas>().enabled = true;
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
}