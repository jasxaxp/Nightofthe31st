using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
   public PlayerHealth playerHealth;
  // public GameObject pixelheart;
   public int heal = 1;

   private void OnTriggerEnter(Collider other)
    { 
        
        if (playerHealth.currentHealth < playerHealth.maxHealth)
        //if(other.gameObject.name.Equals("Player"))
        {
            playerHealth.Heal(heal);
            Destroy(gameObject);
            Debug.Log("You have been healed one point"); 
          //  Destroy(GameObject.Find("MedKit"));
        }
      


    }
       
}

