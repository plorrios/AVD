﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }   
    }

    void Shoot() 
    {
        //shooting logic
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
