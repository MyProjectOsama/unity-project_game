using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        Destroy(gameObject, 2);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
