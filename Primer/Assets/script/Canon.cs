using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{


    public KeyCode shootKeyCode;







     void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("Shoot");
    }



}
