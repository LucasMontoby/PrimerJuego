using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        var direction = new Vector3(horizontal, 0, vertical);
        MoveDirection(direction);
        CharacterDirection();
    }

    private void MoveDirection(Vector3 moveDirection)
    {
        transform.position += moveDirection * (speed * Time.deltaTime);
    }

    
    private void CharacterDirection()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
    }

}
