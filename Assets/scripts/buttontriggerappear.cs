using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttontriggerappear : MonoBehaviour
{
    public GameObject currentTrigger;
    public GameObject buttonOff;
    public GameObject unactivatedTrigger;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   

    void OnTriggerEnter(Collider other)
    {
        currentTrigger.SetActive(false);
        buttonOff.SetActive(false);
    }
    void OnTriggerExit(Collider other)
    {
        unactivatedTrigger.SetActive(true);
    }


}
