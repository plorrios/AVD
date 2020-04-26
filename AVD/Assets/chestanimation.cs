using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class chestanimation : MonoBehaviour
{
    private PlayableDirector director;
    private bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        director = gameObject.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!started)
        {
            director.Play();
            started = true;
        }
    }
}
