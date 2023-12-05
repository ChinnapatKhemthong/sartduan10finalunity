using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuButton : MonoBehaviour
{
    public void LoadMainMenuButton()
    {
        SceneManager.LoadScene("Main");
    }
}