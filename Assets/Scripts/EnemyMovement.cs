using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public NavMeshAgent NAgent;
    public Transform goal;

	// Use this for initialization
	void Start () {
        NAgent = GetComponent<NavMeshAgent>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        NAgent.destination = goal.position;
	
	}
}
