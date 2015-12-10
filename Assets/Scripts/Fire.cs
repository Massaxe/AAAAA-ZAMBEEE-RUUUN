using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
    public LayerMask shootable;
    public float range = 10;
    public RaycastHit rhit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        

        if (Input.GetMouseButton(0))
        {
            Debug.DrawRay(transform.position, transform.forward * 5, Color.green);
            Ray ray = new Ray(transform.position, transform.forward);

            if(Physics.Raycast(ray, out rhit, range, shootable))
            {
                print("Raycast works: " + rhit);
            }
        }
	
	}
}
