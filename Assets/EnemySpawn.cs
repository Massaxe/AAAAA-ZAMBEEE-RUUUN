using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    bool Spawned = false;
    public GameObject Enemy;
    public float SpawnTime = 5;
    EnemyMovement em;
	// Use this for initialization
	void Start () {
        em = new EnemyMovement();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!Spawned)
        {
            StartCoroutine(SpawnTimer());
        }

	
	}
    IEnumerator SpawnTimer()
    {
        Spawned = true;
        Spawn();
        yield return new WaitForSeconds(SpawnTime);
        Spawned = false;
    }
    void Spawn()
    {
        Instantiate(Enemy,transform.position, Quaternion.identity);
    }
}
