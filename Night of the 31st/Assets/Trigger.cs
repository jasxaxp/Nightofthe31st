using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Trigger");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
      print("Trigger");
        
    }
}
