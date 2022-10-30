using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;

    private void OnTriggerEnter(Collision collision) 
    { 
        if(collision.gameObject.tag == "Player") 
        {
            playerHealth.TakeDamage(damage);
            Debug.Log("You have been hit"); 

        }
      


    }
       
    

    
}
