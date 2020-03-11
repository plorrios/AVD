using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Bullet3D : MonoBehaviour
{
    public LayerMask layermask;
    public float speed = 60f;
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
            CharacterData data = gameObject.GetComponent<CharacterData>();
            data.Attack(collision.transform.gameObject.GetComponent<CharacterData>());

        }
        /*Debug.Log(collision.gameObject.name);
        if (layermask == (layermask | (1 << collision.gameObject.layer)))
        {
            rb.Sleep();
            //Die();
            //GetComponent<Animator>().SetTrigger("Die");
        }*/
    }
}