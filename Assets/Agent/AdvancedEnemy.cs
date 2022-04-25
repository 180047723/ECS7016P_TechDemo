/* ENEMY USES BEHAVIOUR AND NAVIGATION TECHNIQUES: 
1. SHOOT 
2. FOLLOW
3. ROTATE
*/
using UnityEngine;
using UnityEngine.AI;

public class AdvancedEnemy : MonoBehaviour
{
    public NavMeshAgent enemyAgent;

    public Transform greenAgent;

    //Shooting agent (attack the greenAgent)
    public float timeofShots;
    bool agentShot;
    public GameObject shoot;

    //States of the enemy to shoot the greenAgent
    public float targetRange, shotRange;
    public bool greenagentInTargetRange, greenagentInTargetRang;

    private void Observe()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //this checks for the target and then fires shots at the greenAgent
        greenagentInTargetRange = Physics.CheckSphere(transform.position, targetRange);
        greenagentInTargetRange = Physics.CheckSphere(transform.position, shotRange);
    
        if (greenagentInTargetRange && greenagentInTargetRange) Shootgreenagent();
    }


   
    private void Shootgreenagent()
    {
        //The enemy doesnt moves but follows/rotates when the greenAgent moves around. 
       enemyAgent.SetDestination(transform.position);

        transform.LookAt(greenAgent);

        if (!agentShot)
        {
            ///the bullets code here
            Rigidbody rb = Instantiate(shoot, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            ///the bullets disappear when the game mode is stopped. 
        }
    }
   
}
