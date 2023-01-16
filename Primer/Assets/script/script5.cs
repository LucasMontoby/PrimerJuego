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
            Instantiate(ball, pointOfShoot);
        }
    }
}

