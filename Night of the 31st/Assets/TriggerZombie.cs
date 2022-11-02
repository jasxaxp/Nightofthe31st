using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZombie : MonoBehaviour
{
	public GameObject player;
	public GameObject enemy;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	public GameObject enemy6;
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
		enemy.GetComponent<ChasingZombie>().enabled = true;
		enemy1.GetComponent<ChasingZombie>().enabled = true;
		enemy2.GetComponent<ChasingZombie>().enabled = true;
		enemy3.GetComponent<ChasingZombie>().enabled = true;
		enemy4.GetComponent<ChasingZombie>().enabled = true;
		enemy5.GetComponent<ChasingZombie>().enabled = true;
		enemy6.GetComponent<ChasingZombie>().enabled = true;
	}
}
