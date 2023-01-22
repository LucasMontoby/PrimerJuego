using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    //public Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
        CountDissapear();
    }

    private void MoveBullet()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }

    private void CountDissapear()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            DissapearBullet();
        }
    }

    private void DissapearBullet()
    {
        Debug.Log("the bull disappears");
        Destroy(gameObject);
    }
}
