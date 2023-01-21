using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Character : MonoBehaviour
{
    [SerializeField] private float speed;
  

    // Update is called once per frame
   void Update()
    {
        Movement();
    }

    private void Movement() 
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 0, (speed * Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, 0, -(speed * Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate((speed * Time.deltaTime), 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-(speed * Time.deltaTime), 0, 0);
        }
    }

}

