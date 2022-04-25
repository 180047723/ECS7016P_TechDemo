/* AGENT USES BEHAVIOUR AND NAVIGATION TECHNIQUES: 
1. MOVE/WANDER 
2. COVER (using walls-yellowcubes)
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AgentMove : MonoBehaviour
{

    // transform array for agent waypoints
    public Transform[] waypointsforAgent; 
    //the speed of the agent (change in the inspector)
    public int speed;  
    
    //private variables the waypoint index (idx) and the distance
    private int waypointAgentidx;
    private float distanceAgent; 

    // start function that starts the waypoints for the agent 
    void Start()
    {
        //starts from the first position
        waypointAgentidx = 0; 
        //Agent will be moving forward towards the waypoint
        transform.LookAt(waypointsforAgent[waypointAgentidx].position);
    }
    // Updates the distance 
    void Update()
    {
        distanceAgent = Vector3.Distance(transform.position, waypointsforAgent[waypointAgentidx].position); 
        // if the distance is greater than 1 it will increase/ increment the waypoint index
        if (distanceAgent < 1f)
        {
            IncrementwpIdx(); 
        }
        //agent moving 
       agentMoving(); 
    }

    //movements of agent
    void agentMoving()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }

    //this function increments the waypoint index
    void IncrementwpIdx()
    {
        waypointAgentidx++; 
        if (waypointAgentidx >= waypointsforAgent.Length)
        {
            waypointAgentidx = 0; 
        }
        transform.LookAt(waypointsforAgent[waypointAgentidx].position);
    }
}
