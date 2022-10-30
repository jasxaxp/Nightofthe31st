using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
   public PlayerHealth playerHealth;
   public int heal = 1;

    private void onCollisionEnter(Collision collision) 
    { 
        if(collision.gameObject.tag == "Player") 
        {
            playerHealth.Heal(heal);

        }
      


    }
       
}
