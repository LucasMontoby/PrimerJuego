using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    //public Vector3 direction;
    
    [SerializeField] private Transform pointOfShoot;
    [SerializeField] private GameObject ball;
    [SerializeField] private float damage;
    [SerializeField] private float repeatRate = 0.3f;
    [SerializeField] private float speed;

    private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }
}



