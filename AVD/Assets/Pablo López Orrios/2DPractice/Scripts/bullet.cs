using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float TimeToLive = 5f;
    private Animator animator;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        audio = gameObject.GetComponent<AudioSource>();
        rb.velocity = transform.right;
        Destroy(gameObject, TimeToLive);
    }

    public void explosion()
    {

        Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) { Destroy(collision.gameObject); animator.SetBool("Hit",true); audio.Play(); rb.velocity = new Vector2(0,0); }


    }
}
