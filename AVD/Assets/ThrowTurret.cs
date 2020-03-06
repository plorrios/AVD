using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowTurret : MonoBehaviour
{
    public GameObject sphere;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { Instantiate(sphere, gameObject.transform.position, gameObject.transform.rotation); }
    }
}
