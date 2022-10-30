using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;

    private void onCollisionEnter(Collision collision) 
    { 
        if(collision.gameObject.tag == "Player") 
        {
            playerHealth.TakeDamage(damage);

        }
      


    }
       
    

    
}
