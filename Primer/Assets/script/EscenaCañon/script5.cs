using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script5 : MonoBehaviour
{
    public GameObject ball;
    public Transform pointOfShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checImput();
    }

    public void checImput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, pointOfShoot); /*pointOfShoot.position, pointOfShoot.rotation*/
        }
    }

    //function FixedUpdate()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        FireFunction();
    //    }
    //}

    //function FireFunction()
    //{
    //    yield WaitForSeconds(5);

    //    clone = Instantiate(projectile, transform.position, transform.rotation);
    //    clone.velocity = transform.TransformDirection(Vector3(0, 0, speed));
    //}
}

