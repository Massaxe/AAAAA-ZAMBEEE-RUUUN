using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public NavMeshAgent NAgent;
    public Transform goal;
    public AudioSource ad;
    public bool PlayerDead = false;
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
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Destroy(col.collider.gameObject);
            PlayerDead = true;
        }
    }
    public void DieSound()
    {
        ad.Play();


    }
}
