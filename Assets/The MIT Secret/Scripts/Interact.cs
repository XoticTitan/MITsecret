using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public string triggerName = "";
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;
    public GameObject KeyImage1;
    public GameObject KeyImage2;
    public GameObject KeyImage3;
    public GameObject SpecialDoor;
    public GameObject SpecialDoor2;
    public GameObject Window;
    public GameObject Wall;
    public GameObject Slender1sight;
    public GameObject player;
    public Transform destination;
    public GameObject win;
    public GameObject Message1;
    public GameObject Slender1;
    public GameObject Slender2;
    public GameObject Slender3;
    public Transform S1D1;
    public Transform S1D2;
    public Transform S2D1;
    public Transform S2D2;
    public Transform S3D1;
    public Transform S3D2;
    public Transform K1D1;
    public Transform K1D2;
    public Transform K2D1;
    public Transform K2D2;
    public GameObject end;
    public GameObject endCube;

    void Start()
    {
        Key1.SetActive(true);
        Key2.SetActive(false);
        Key3.SetActive(false);
        KeyImage1.SetActive(false);
        KeyImage2.SetActive(false);
        KeyImage3.SetActive(false);
        SpecialDoor.SetActive(true);
        SpecialDoor2.SetActive(true);
        Window.SetActive(true);
        Wall.SetActive(true);
        win.SetActive(false);
        Message1.SetActive(false);
        end.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(triggerName == "Key2")
            {
                Key2.SetActive(false);
                KeyImage2.SetActive(true);
                Key3.SetActive(true);
            }

            if(triggerName == "Key1")
            {
                Key1.SetActive(false);
                KeyImage1.SetActive(true);
                Key2.SetActive(true);
            }

            if(triggerName == "Key3")
            {
                Key3.SetActive(false);
                KeyImage3.SetActive(true);
                SpecialDoor.SetActive(false);
                SpecialDoor2.SetActive(false);
                Window.SetActive(false);
                Wall.SetActive(false);
                end.SetActive(false);
            }



        }

            if(triggerName == "Capsule")
            {
        
                    transform.position = destination.position;
                    Reset();
            }

            if(triggerName == "Win")
            {
                win.SetActive(true);
            }

            if(triggerName == "Cube (7)")
            {
                Slender1.transform.position = S1D1.position;
                Slender2.transform.position = S2D2.position;
                Slender3.transform.position = S3D1.position;
                Key1.transform.position = K1D1.position;
                Key2.transform.position = K2D1.position;
            }

            if(triggerName == "Cube (8)")
            {
                Slender1.transform.position = S1D2.position;
                Slender2.transform.position = S2D1.position;
                Slender3.transform.position = S3D2.position;
                Key1.transform.position = K1D2.position;
                Key2.transform.position = K2D2.position;
            }



    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }

    void Reset()
    {
        KeyImage1.SetActive(false);
        KeyImage2.SetActive(false);
        KeyImage3.SetActive(false);
        Key1.SetActive(true);
    }
}