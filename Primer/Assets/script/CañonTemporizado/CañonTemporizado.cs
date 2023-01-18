using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonTemporizado : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    [SerializeField] private float lifetime;
    public Transform pointOfShoot;
    public GameObject ball;

    public KeyCode keyToPress;
    public float scaleAmount;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ChecImput();
        CountDissapear();
     
    }

    private void CountDissapear()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            DissapearBull();
        }
    }

    private void DissapearBull()
    {
        Debug.Log("the bull disappears");
    }

    public void ChecImput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, pointOfShoot.position, pointOfShoot.rotation);
        }
    }


}
