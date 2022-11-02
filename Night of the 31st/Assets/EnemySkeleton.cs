using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkeleton : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;

    private void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.name.Equals("Player"))
        {
            playerHealth.TakeDamage(damage);
            Debug.Log("You have been hit one point"); 
        }
    }
}
