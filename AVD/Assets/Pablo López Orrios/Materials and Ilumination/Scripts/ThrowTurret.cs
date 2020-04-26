using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowTurret : MonoBehaviour
{
    public GameObject sphere;
    private float timeStamp;
    public float cooldownTime = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timeStamp <= Time.time)
        {
            Instantiate(sphere, gameObject.transform.position, gameObject.transform.rotation);
            timeStamp = Time.time + cooldownTime;
        }
    }
}
