using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Transform Player;
    public float smoothDamp = 0.1f;
    Vector3 v3 = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = new Vector3(Player.position.x, transform.position.y, Player.position.z - 50);

        transform.position = Vector3.SmoothDamp(transform.position, playerPos,ref v3, smoothDamp);
	
	}
}
