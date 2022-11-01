using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWizard : MonoBehaviour
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
		enemy.GetComponent<ChasingWizard>().enabled = true;
		enemy1.GetComponent<ChasingWizard>().enabled = true;
		enemy2.GetComponent<ChasingWizard>().enabled = true;
		enemy3.GetComponent<ChasingWizard>().enabled = true;
		enemy4.GetComponent<ChasingWizard>().enabled = true;
		enemy5.GetComponent<ChasingWizard>().enabled = true;
		enemy6.GetComponent<ChasingWizard>().enabled = true;
		enemy7.GetComponent<ChasingWizard>().enabled = true;
 	}
}
