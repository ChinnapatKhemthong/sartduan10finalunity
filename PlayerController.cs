using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public DoorController door1;

    public float eyeDistance = 5.0f;
    private Ray ray;
    private RaycastHit hitData;
    public TextMeshProUGUI infoText;


    public AudioSource sourcedoor1;

    void Start()
    {
        infoText.gameObject.SetActive(false);
    }

    void Update()
    {



        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction * eyeDistance, Color.red);

        if (Physics.Raycast(ray, out hitData, eyeDistance))
        {
            switch (hitData.transform.gameObject.tag)
            {
                case "door1":
                    infoText.text = "Press F to open/close";
                    infoText.gameObject.SetActive(true);
                    Debug.DrawRay(ray.origin, ray.direction * eyeDistance, Color.blue);

                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        door1.control();
                        sourcedoor1.Play();
                    }
                    break;

            }
        }
        else
        {
            infoText.gameObject.SetActive(false);
        }
    }

}