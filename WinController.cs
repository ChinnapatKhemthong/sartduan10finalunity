using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WinController : MonoBehaviour
{
    public GameObject WinMenu;
    public GameObject Player;
    public GameObject Timer;
    void Start()
    {
        WinMenu.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WinEiei")
        {
            GameWin();
            Timer.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Player.GetComponent<FirstPersonController>().enabled = false;
        }
    }

    public void GameWin()
    {
        WinMenu.gameObject.SetActive(true);
    }
}