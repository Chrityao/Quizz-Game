using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void MenuButton()
    {
     SceneManager.LoadScene("MainMenu");
    }

    public void LocalButton()
    {
        SceneManager.LoadScene("Pong");
    }
}
