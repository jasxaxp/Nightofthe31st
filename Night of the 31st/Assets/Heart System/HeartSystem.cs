using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    [SerializeField] GameObject panel;
public GameObject[] hearts;
public GameObject Player;
private int life;
private bool dead;



    private void Start()
    {
        life = hearts.Length;
         panel.SetActive(false);
    }


    void OpenPanel()
    {
        panel.SetActive(true);

    }

    void Update()
    {
        if (dead == true)
        {
        Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        TakeDamage(1);
    }
    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if(life < 1)
            {
                dead = true;
                OpenPanel();
            }
        }
    }
}
