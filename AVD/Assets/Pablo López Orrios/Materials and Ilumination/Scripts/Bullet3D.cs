using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Bullet3D : MonoBehaviour
{
    public LayerMask layermask;
    public float speed = 100f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Destroy(gameObject, 2f);
        rb.AddRelativeForce(-transform.forward * speed, ForceMode.Impulse);
    }

    public void Die() 
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (layermask == (layermask | (1 << collision.gameObject.layer)))
        {
            CharacterData enemydata = collision.transform.gameObject.GetComponent<CharacterData>();
            enemydata.Stats.ChangeHealth(-enemydata.Stats.CurrentHealth);
        }
    }
}