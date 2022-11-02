using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
	public GameObject zombie;
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
			ScoreScript.scoreValue += 1;
			this.gameObject.GetComponent<Animation>().Play("Death");
			this.gameObject.GetComponent<ChasingZombie>().enabled = false;
			this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
			this.gameObject.transform.GetChild(5).gameObject.gameObject.SetActive(false);
		}
	}
}
