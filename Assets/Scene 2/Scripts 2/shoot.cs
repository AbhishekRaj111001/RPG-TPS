using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    float bulletSpeed = 1;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Fire()
    {
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidbodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidbodyBullet.AddForce(tempRigidbodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Fire();
        }
    }
}
