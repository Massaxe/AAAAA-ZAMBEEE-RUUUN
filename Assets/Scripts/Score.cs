using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public bool PlayerDead = false;
    public float killCount;
    public GameObject player;
    public Canvas c;
	// Use this for initialization
	void Start () {
        c.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
        {
            print("Its working");
            c.enabled = true;

        }

	
	}
    public void KillCounter()
    {
        //if (!PlayerDead)
        //{
            killCount += 1;
        print("yep: " + killCount.ToString());
        //}
    }
}
