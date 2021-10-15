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
    void OnCollisionEnter()
    {
        if (CompareTag("geometry"))
        {
            Destroy(gameObject);
        }
    }
    
}
