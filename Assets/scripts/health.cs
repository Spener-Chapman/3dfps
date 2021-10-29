using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    int[] healthamount;
    // 0 = mashine gun player
    // 1 = tank
    // 2 = healer
    int[] damage;
    // 0 machine gun player
    // 1 = tank // maybe make shotgun?
    // 2 = healer

    int playerhealth;
    


    // Start is called before the first frame update
    void Start()
    {
        healthamount = new int[3];
        healthamount[0] = 250;
        healthamount[1] = 600;
        healthamount[2] = 200;

        damage = new int[3];
        damage[0] = 18;
        damage[1] = 1;
        damage[2] = 11;
    }

    // Update is called once per frame
    void Update()
    {
        playerhealth = 10;


        
        if (playerhealth <= 0)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            playerhealth = (playerhealth - damage[0]);
        }
    }
}
