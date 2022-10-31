using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringGun : MonoBehaviour
{
	public GameObject theGun;
	public bool Firing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
		{
			if (Firing == false)
			{
				StartCoroutime(GunMechanics());
			}
		}
    }
	IEnumerator GunMechanics()
	{
		Firing = true;
		yield return new WaitForSeconds(0.25f);
		Firing = false;
	}
}
