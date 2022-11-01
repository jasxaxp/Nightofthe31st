using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
            print("Trigger");
            Debug.Log("Triggered 2");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
      print("Trigger");
      Debug.Log("Triggered 1");
        
    }




}
