using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : MonoBehaviour
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
		enemy.GetComponent<ChasingPumpking>().enabled = true;
		enemy1.GetComponent<ChasingPumpking>().enabled = true;
		enemy2.GetComponent<ChasingPumpking>().enabled = true;
		enemy3.GetComponent<ChasingPumpking>().enabled = true;
		enemy4.GetComponent<ChasingPumpking>().enabled = true;
		enemy5.GetComponent<ChasingPumpking>().enabled = true;
		enemy6.GetComponent<ChasingPumpking>().enabled = true;
 	}
}