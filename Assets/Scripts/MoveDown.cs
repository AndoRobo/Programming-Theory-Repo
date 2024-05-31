using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5f;

    private float zDestroy = -15f;
    private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       objectRb.AddForce(Vector3.forward * -speed);

        if (transform.position.z < zDestroy)

        {
            Destroy(gameObject);
        }

    }
}
