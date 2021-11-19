using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bulletprojectile : MonoBehaviour
{
    public Rigidbody bullet;

    public float speed = 1;

    float fireTime = 0.0f;
    float fireDelay = 0.1f;
    int ammo = 32;
    float reloadTime = 1.0f;
    float reloadDelay = 1.0f;

    public TextMeshProUGUI countText;
    int count = 32;

    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {
        Reload();
        Fire();
        SetAmmoText();
    }

    void Reload()
    {
        reloadTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.R))
        {
            ammo = 32;
            reloadTime = 0.0f;
            count = 32;
        }
    }
    void Fire()
    {
        fireTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0) && fireTime >= fireDelay && ammo > 0 && reloadTime >= reloadDelay)
        {

            Rigidbody instantiatedBullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            instantiatedBullet.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

            fireTime = 0;
            ammo = ammo - 1;
            count = count - 1;
        }
    }
    void SetAmmoText()
    {
        countText.text = "Ammo: " + count.ToString();
        if (count >= 32)
        {
            count = 32;
        }
        if (count <= 0)
        {
            count = 0;
        }
    }
}
