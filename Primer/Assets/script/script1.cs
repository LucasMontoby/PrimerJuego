using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public Vector3 scale;
    public Vector3 positions;
    public Vector3 movement;
    public Vector3 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = scale;
        transform.localPosition = positions;

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += movement;
        transform.position += speed * direction;

    }
}
