using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalbutton : MonoBehaviour
{
    public GameObject currentTrigger;
    public GameObject buttonOff;
    public GameObject trophy;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    void OnTriggerEnter(Collider other)
    {
        trophy.SetActive(true);
        currentTrigger.SetActive(false);
        buttonOff.SetActive(false);
        
    }
    


}