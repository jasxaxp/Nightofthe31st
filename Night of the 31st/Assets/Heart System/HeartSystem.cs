
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;


    private void Start()
    {
        life = hearts.Length;
        dead = life < 1;
    }

    void Update()
    {
        if (dead == true)
        {
            Debug.Log("We are dead!");
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= 1;
            Destroy(hearts[life].gameObject);
            if(life < 1)
            {
                dead = true;
                
            }
        }
    }
}
