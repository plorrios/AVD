using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float runSpeed = 40f;
    [SerializeField]
    float horizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { rigidbody.AddForce( new Vector2(0,100)); }
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    }
}
