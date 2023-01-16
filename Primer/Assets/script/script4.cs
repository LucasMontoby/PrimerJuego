using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script4 : MonoBehaviour
{
    public GameObject bullet;
    public Transform pointOfShoot;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bullet, pointOfShoot);
    }
}
