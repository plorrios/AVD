using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallController : MonoBehaviour
{
    public Transform respawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision);
            collision.gameObject.GetComponent<Rigidbody2D>().Sleep();
            collision.gameObject.transform.position = respawnPoint.position;
            collision.gameObject.GetComponent<Rigidbody2D>().WakeUp();
        }
    }
}
