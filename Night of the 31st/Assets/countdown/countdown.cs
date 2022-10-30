using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    [SerializeField] GameObject panel;

    [SerializeField] Image timeImage;

    [SerializeField] Text timeText;

    [SerializeField] float duration, currentTime;


    void Start()
    {
        panel.SetActive(false);
        currentTime = durration;
        timeText.text - currentTime.ToString();
        StartCoroutine(TimeIEn());       
    }

  
}
