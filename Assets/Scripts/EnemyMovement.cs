using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public NavMeshAgent NAgent;
    public Transform goal;
	// Use this for initialization
	void Start () {
        NAgent = GetComponent<NavMeshAgent>();
        goal = GameObject.FindGameObjectWithTag("Player").transform;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (goal != null)
        {
            NAgent.destination = goal.position; 
        }
	
	}
}
