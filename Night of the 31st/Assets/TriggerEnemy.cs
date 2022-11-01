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
	public GameObject enemy6;
	public GameObject enemy5;
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
	public GameObject enemy21;
	public GameObject enemy22;
	public GameObject enemy23;
	public GameObject enemy24;
	public GameObject enemy25;
	public GameObject enemy26;
	public GameObject enemy27;
	public GameObject enemy28;
    public GameObject enemy29;
	public GameObject enemy30;
	public GameObject enemy31;
	public GameObject enemy32;
	public GameObject enemy33;
	public GameObject enemy34;
	public GameObject enemy35;
	public GameObject enemy36;
	public GameObject enemy37;
	public GameObject enemy38;
	public GameObject enemy39;
	public GameObject enemy40;

	
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