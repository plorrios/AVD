using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;

    public bool shooting = true;
    public float frequency = 1;

    private AudioSource audio;

    public Transform[] shootingPoints;
    public Animator[] GunsAnimators;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }

    public void Comienza()
    {
        StartCoroutine(Fire());
    }
    private int i = 0;
    IEnumerator Fire()
    {
        GunsAnimators[i].SetTrigger("Fire");
        audio.Play();
        Instantiate(bullet, shootingPoints[i].position, shootingPoints[i].rotation);
        i++;
        if (i >= shootingPoints.Length) i = 0;
        yield return new WaitForSeconds(frequency);
        StartCoroutine(Fire());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
