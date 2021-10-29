using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_despawn : MonoBehaviour
{
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "geometry")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
    
}
