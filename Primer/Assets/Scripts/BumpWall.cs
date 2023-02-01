using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 

public class BumpWall : MonoBehaviour
{
    [SerializeField] private float impactTime = 2f;
    private float _currentTime;


    private void OnCollisionStay(Collision collision)
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= impactTime &&
        collision.gameObject.TryGetComponent<HarryController>(out var harryController))
        {
            _currentTime = 0;

            transform.position = new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30));
        }
    }

}



//[SerializeField] private Transform[] newPositions;

//public Transform GetPosition()
//    {
//         return newPositions[Random.Range(0, newPositions.Length)];
//    }
