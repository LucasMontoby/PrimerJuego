using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    [SerializeField] private Transform[] newPositions;

    public Transform GetPosition()
    {
        return newPositions[Random.Range(0, newPositions.Length)];
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision");

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision");
    }

}


