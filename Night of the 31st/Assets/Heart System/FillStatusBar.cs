using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
//    public Image fillImage;
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

//    void Awake()
//    {
 //       slider = GetComponent<Slider>();
 //   }


    //void Update()
   // {
   //     float fillValue = (playerHealth.currentHealth / playerHealth.maxHealth);
   //     slider.value = fillValue;
  //  }
}


