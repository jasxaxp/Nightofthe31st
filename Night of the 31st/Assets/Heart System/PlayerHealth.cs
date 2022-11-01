using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{  
    [SerializeField] GameObject panel;
    public Camera playerCamera;
    public FillStatusBar fillStatusBar;
    public int maxHealth = 5;
    public int currentHealth;
	public AudioClip hurt;

    void Start()
    {
        currentHealth = maxHealth;
    }
    
    void OpenPanel()
    {
        panel.SetActive(true);

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
		 AudioSource.PlayClipAtPoint(hurt, transform.position, 1);

        if(currentHealth < 0)  
        {
            Debug.Log("You are dead");
            print("You are dead");
            OpenPanel();
            Destroy(gameObject);

        }
         
    }

     public void Heal(int amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        
    }
}
