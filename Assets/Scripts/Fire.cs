using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
    public LayerMask shootable;
    public float range = 10;
    public RaycastHit rhit;
    LineRenderer fireLine;
    public bool Fired = false;
    public float fireRate = 1;
	// Use this for initialization
	void Start () {
        fireLine = GetComponent<LineRenderer>();
        fireLine.enabled = false;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {


        if (Input.GetMouseButton(0) && !Fired)
        {
            StartCoroutine(fireTimer());
            fireLine.enabled = true;
        }
        else
            fireLine.enabled = false;
        
	
	}
    void PlayerFire()
    {

        Debug.DrawRay(transform.position, transform.forward * 5, Color.green);
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out rhit, range, shootable))
        {
            print("Raycast works: " + rhit);
            Destroy(rhit.transform.gameObject);
        }
    }
    IEnumerator fireTimer()
    {
        Fired = true;
        PlayerFire();
        yield return new WaitForSeconds(fireRate);
        Fired = false;

    }
}
