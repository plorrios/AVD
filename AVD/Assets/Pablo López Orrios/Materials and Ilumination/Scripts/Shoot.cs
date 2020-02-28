using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;

    public bool shooting = true;

    public Transform shootingPoint, shootingPoint2, shootingPoint3, shootingPoint4;

    public void Comienza()
    {
        StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        shooting = true;

        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
        yield return new WaitForSeconds(0.3f);
        
        Instantiate(bullet, shootingPoint2.position, shootingPoint2.rotation);
        yield return new WaitForSeconds(0.3f);

        Instantiate(bullet, shootingPoint3.position, shootingPoint3.rotation);
        yield return new WaitForSeconds(0.3f);

        Instantiate(bullet, shootingPoint4.position, shootingPoint4.rotation);
        yield return new WaitForSeconds(0.3f);


       // if (shooting) StartCoroutine(Fire());
    }

    public void stopShooting() { 
        shooting = false; 
        StopCoroutine(Fire());
    }

}
