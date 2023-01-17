using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script3 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Bullet();
    }

    private void Bullet()
    {
        transform.position += _speed * _direction;
    }
}
