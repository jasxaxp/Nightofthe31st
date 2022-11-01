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
			Destroy(gameObject);
			this.gameObject.GetComponent<ChasingWizard>().enabled = false;
			this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
		}
	}
}
