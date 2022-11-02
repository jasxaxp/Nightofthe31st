using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardEnemy : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;
	public GameObject wizard;
	private Animation anim;

    private void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.name.Equals("Player"))
        {
			anim = wizard.GetComponent<Animation>();
			anim.Play("attack_short_001");
            playerHealth.TakeDamage(damage);
            Debug.Log("You have been hit one point"); 
        }
    }
}
