using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardsHealth : MonoBehaviour
{
	public GameObject wizard;
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
			this.gameObject.GetComponent<Animation>().Play("dead");
			this.gameObject.GetComponent<ChasingWizard>().enabled = false;
			this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
			this.gameObject.transform.GetChild(6).gameObject.gameObject.SetActive(false);
		}
	}
}
