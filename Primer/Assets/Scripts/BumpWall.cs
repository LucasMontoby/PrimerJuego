using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 

public class BumpWall : MonoBehaviour
{
    [SerializeField] private float _impactTime = 2f;
    [SerializeField] private Transform[] _newPositions;
    private float _currentTime;


    private void OnCollisionStay(Collision collision)
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _impactTime &&
        collision.gameObject.TryGetComponent<HarryController>(out var harryController))
        {
            _currentTime = 0;

            transform.position = new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30));
        }
    }

    public Transform GetPosition()
    {
        return _newPositions[Random.Range(0, _newPositions.Length)];
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
