using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBall : MonoBehaviour
{

    public LayerMask layermask;
    private Rigidbody rb;
    public float force = 100f;
    public GameObject Turret;
    private bool instantiated = true;

    private void Start()
    {
        Vector3 v = new Vector3(0, 0, force);
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddRelativeForce(v);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (instantiated)
        {
            instantiated = false;
            Vector3 v2 = new Vector3(collision.contacts[0].point.x, collision.contacts[0].point.y + 0.321f, collision.contacts[0].point.z);
            if (layermask == (layermask | (1 << collision.gameObject.layer)))
            {
                Instantiate(Turret, v2, gameObject.transform.rotation);
            }
            Destroy(gameObject);
        }
    }
}
