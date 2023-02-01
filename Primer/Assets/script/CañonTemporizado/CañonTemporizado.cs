using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class CañonTemporizado : MonoBehaviour
{
    [SerializeField] private Transform pointOfShoot;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject ball2;
    [SerializeField] private GameObject ball3;
    [SerializeField] private GameObject ball4;
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;

    // Update is called once per frame
    void Update()
    {
        ChecImput();
        CountDissapear();
    }

    public void ChecImput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(ball, pointOfShoot.position, pointOfShoot.rotation);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(ball2, pointOfShoot.position, pointOfShoot.rotation);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(ball3, pointOfShoot.position, pointOfShoot.rotation);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(ball4, pointOfShoot.position, pointOfShoot.rotation);
        }

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
        Destroy(ball);
    }
}