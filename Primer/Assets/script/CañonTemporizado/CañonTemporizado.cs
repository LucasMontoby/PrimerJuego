using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonTemporizado : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] Transform pointOfShoot;
    [SerializeField] GameObject ball;

    // Update is called once per frame
    void Update()
    {
        ChecImput();
    }

    public void ChecImput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, pointOfShoot.position, pointOfShoot.rotation);
        }
    }
    
}
