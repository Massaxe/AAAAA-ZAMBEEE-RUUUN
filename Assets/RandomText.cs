using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RandomText : MonoBehaviour {

    public Text t;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        t.text = "Hello dane i thnk i lick u";

	
	}
}
