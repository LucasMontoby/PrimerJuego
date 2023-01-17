using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    [SerializeField] private int _life;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        CurePlayer();

        MovePlayer();   

        DamagePlayer();

        ModifyHealth(20);
    }

    private void CurePlayer()
    {
        _life += 1;
    }

    private void MovePlayer()
    {
        transform.position += _speed * _direction;
    }

    private void DamagePlayer()
    {
        _life -= 1;
        Debug.Log("Life reduction: 1");
    }

    private void ModifyHealth(int value)
    {
        
        _life += value;
    }
}
