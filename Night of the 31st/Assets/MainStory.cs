using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;

public class MainStory : MonoBehaviour
{
   
    void OnEnable()
    {
        SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
    }

}
