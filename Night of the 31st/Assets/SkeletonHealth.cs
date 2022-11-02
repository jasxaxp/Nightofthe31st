using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
public class SkeletonHealth : MonoBehaviour
{
	public int health = 5;
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
			if (health <= 0)
			{
				Destroy(gameObject);
				ScoreScript.scoreValue += 1;
				this.gameObject.GetComponent<AudioSource>().enabled = false;
				this.gameObject.transform.GetChild(2).gameObject.SetActive(false);
				this.gameObject.GetComponent<ChasingSkeleton>().enabled = false;
				this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
			}
			else
			{
				health -= 1;
			}
		}
	}
}
