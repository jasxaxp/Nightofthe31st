using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSkeleton : MonoBehaviour
{
	public GameObject player;
	public GameObject enemy;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter(Collider other) 
	{
		// enable script on GameObject when player enters trigger
		enemy.GetComponent<ChasingSkeleton>().enabled = true;
		enemy1.GetComponent<ChasingSkeleton>().enabled = true;
		enemy2.GetComponent<ChasingSkeleton>().enabled = true;
		enemy3.GetComponent<ChasingSkeleton>().enabled = true;
	}
}
