using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3D : MonoBehaviour
{
    public float speed = 60f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb.AddRelativeForce(-transform.forward*speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) { Destroy(collision.gameObject); Destroy(gameObject); }


    }
}