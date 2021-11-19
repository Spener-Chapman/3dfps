using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BADbutton : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public GameObject button1Good;
    public GameObject button1Bad;
    public GameObject button2Good;
    public GameObject button2Bad;
    public GameObject button3Good;
    public GameObject button3Bad;

    public GameObject currentButtonDown;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);

        

        button1Good.SetActive(false);
        button2Good.SetActive(false);
        button3Good.SetActive(false);

        button1Bad.SetActive(true);
        button2Bad.SetActive(true);
        button3Bad.SetActive(true);

        currentButtonDown.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        currentButtonDown.SetActive(true);
        
    }
}
