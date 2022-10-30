using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MenuButton : MonoBehaviour
{
    public void MenuButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}