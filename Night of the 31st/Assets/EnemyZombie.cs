using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombie : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;
	public GameObject zombie;
	private Animation anim;

    private void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.name.Equals("Player"))
        {
			anim = zombie.GetComponent<Animation>();
			anim.Play("Attack1");
            playerHealth.TakeDamage(damage);
            Debug.Log("You have been hit one point"); 
        }
      


    }
}
