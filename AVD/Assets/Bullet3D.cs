using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3D : MonoBehaviour
{
    public LayerMask layermask;
    public float speed = 60f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(-transform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, 3f);
    }

    public void Die() 
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name);
        if (layermask == (layermask | (1 << collision.gameObject.layer)))
        {
            rb.Sleep();
            GetComponent<Animator>().SetTrigger("Die");
        }
    }
}