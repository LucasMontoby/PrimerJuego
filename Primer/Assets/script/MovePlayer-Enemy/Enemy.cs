using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float speedToLook;
    [SerializeField] float speed;
    [SerializeField] float persuitDistance;
    [SerializeField] private enemyState currentEstate;

    public enum enemyState
    {
        LookAtPlayer,
        MoveEnemy2, 
        fullEnemy
    }

    void Update()
    {
        switch (currentEstate)
        {
            case enemyState.LookAtPlayer:
            LookAtPlayer();
            break;  
            case enemyState.MoveEnemy2: 
            MoveEnemy2();   
            break;
            case enemyState.fullEnemy:
            LookAtPlayer();
            MoveEnemy2();
            break;  

        }
    }

    private void LookAtPlayer()
    {
        Quaternion newRotations = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotations, speedToLook * Time.deltaTime);
    }

    private void MoveEnemy2()
    {
        var vectorPlayer = playerTransform.position - transform.position;
        var distance = vectorPlayer.magnitude;

        if (distance > persuitDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            playerTransform.position, Time.deltaTime * speed);
        }
    }
}
