using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletprojectile : MonoBehaviour
{
    public Rigidbody bullet;

    public float speed = 100;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Rigidbody instantiatedBullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            instantiatedBullet.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        } 
    }

}
