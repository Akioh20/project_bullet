using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{
    public float speed;
    public float distance = 2f;
    public float stopDistance;

    private bool rightMove = true;
    public bool activePatrol = true;

    public Transform groundDetector;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetector.position, Vector2.down, distance);

        if (groundInfo.collider == false)
        {
            if (rightMove == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 90);
                rightMove = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 90);
                rightMove = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}