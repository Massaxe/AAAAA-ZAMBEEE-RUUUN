using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
    private Rigidbody Player;

	// Use this for initialization
	void Start () {
        Player = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float mx = Input.GetAxis("Horizontal");
        float mz = Input.GetAxis("Vertical");
        var movement = new Vector3(mx, 0f, mz);

        //Player.velocity += movement * speed * Time.deltaTime;
        transform.position += (movement * speed * Time.deltaTime);

        //if (movement == Vector3.zero)
           // Player.velocity = new Vector3(0, 0, 0);
	
	}
}
