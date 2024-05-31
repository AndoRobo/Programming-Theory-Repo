using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;

    public float speed = 10.0f;
    private float zBoundPositive = 3;
    private float zBoundNegative = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        MovePLayer();
        ConstrainPlayerPosition();
       
    }
    // Moves the player based on keys
    void MovePLayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
       
        // moves  player up or down on z axis
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        // moves player  left or rigth on x axis
        playerRb.AddForce(Vector3.right * speed * horizontalInput); 

    }
    // Prevent player from leaving the top or bottom of the screen
    void ConstrainPlayerPosition()
    {
        // bottom of the screen
        if (transform.position.z < zBoundNegative)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundNegative);
        }
        // top of the screen
        if (transform.position.z > zBoundPositive)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundPositive);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player has collided with enemy");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}
