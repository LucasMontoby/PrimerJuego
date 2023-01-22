using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Character : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical   = Input.GetAxisRaw("Vertical");
        var direction  =  new Vector3(horizontal, 0, vertical);
        MoveDirection(direction);
    }
    private void MoveDirection(Vector3 moveDirection)
    {
        transform.position += moveDirection * (speed * Time.deltaTime);

    }
}

//if (Input.GetKeyDown(KeyCode.W))
//{
//    transform.Translate(0, 0, (speed * Time.deltaTime));
//}

//if (Input.GetKeyDown(KeyCode.S))
//{
//    transform.Translate(0, 0, -(speed * Time.deltaTime));
//}

//if (Input.GetKeyDown(KeyCode.D))
//{
//    transform.Translate((speed * Time.deltaTime), 0, 0);
//}

//if (Input.GetKeyDown(KeyCode.A))
//{
//    transform.Translate(-(speed * Time.deltaTime), 0, 0);
//}
