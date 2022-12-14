using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PumpkingHealth : MonoBehaviour
{
	public GameObject pumpking;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	void OnTriggerEnter(Collider collision)
	{
		if (collision.transform.tag == "Bullet")
		{
			Destroy(gameObject);
			ScoreScript.scoreValue += 1;
			this.gameObject.GetComponent<AudioSource>().enabled = false;
			this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
			this.gameObject.GetComponent<ChasingPumpking>().enabled = false;
			this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
		}
	}
}
