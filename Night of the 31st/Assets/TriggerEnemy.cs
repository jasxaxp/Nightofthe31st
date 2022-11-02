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
	public GameObject enemy7;
	public GameObject enemy8;
	public GameObject enemy9;
	public GameObject enemy10;
	public GameObject enemy11;
	public GameObject enemy12;
	public GameObject enemy13;
	public GameObject enemy14;
	public GameObject enemy15;
	public GameObject enemy16;
	public GameObject enemy17;
	public GameObject enemy18;
	public GameObject enemy19;
	public GameObject enemy20;
	
	

	
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
		enemy7.GetComponent<ChasingPumpking>().enabled = true;
		enemy8.GetComponent<ChasingPumpking>().enabled = true;
		enemy9.GetComponent<ChasingPumpking>().enabled = true;
		enemy10.GetComponent<ChasingPumpking>().enabled = true;
		enemy11.GetComponent<ChasingPumpking>().enabled = true;
		enemy12.GetComponent<ChasingPumpking>().enabled = true;
		enemy13.GetComponent<ChasingPumpking>().enabled = true;
		enemy14.GetComponent<ChasingPumpking>().enabled = true;
		enemy15.GetComponent<ChasingPumpking>().enabled = true;
		enemy16.GetComponent<ChasingPumpking>().enabled = true;
		enemy17.GetComponent<ChasingPumpking>().enabled = true;
		enemy18.GetComponent<ChasingPumpking>().enabled = true;
		enemy19.GetComponent<ChasingPumpking>().enabled = true;
		enemy20.GetComponent<ChasingPumpking>().enabled = true;
		
 	}
}