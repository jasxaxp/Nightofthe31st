using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
	float bulletSpeed = 3000;
	public GameObject bullet;
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
				StartCoroutine(Fire());
			}
		}
    }
	
	IEnumerator Fire()
	{
		Firing = true;
		GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
		Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
		tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
		Destroy(tempBullet, 1.5f);
		yield return new WaitForSeconds(0.10f);
		Firing = false;
	}
}
