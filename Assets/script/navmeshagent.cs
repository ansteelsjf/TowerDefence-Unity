using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class navmeshagent : MonoBehaviour
{
    public NavMeshAgent agent;
    public Vector3 position;
    public GameObject destination;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        position = new Vector3(1.91f, 0.48f, -6.19f);


    }

    // Update is called once per frame
    void Update()
    {
       
        agent.SetDestination(position);
        
        
    }
}