using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class SimpleGo : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform destination;
    public Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        //agent.destination = destination.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log(Physics.Raycast(cameraTransform.position, destination.position));
            //agent.destination = Physics.RaycastAll(cameraTransform.position, destination.position)[0].transform.position;
            
        }
    }
}
