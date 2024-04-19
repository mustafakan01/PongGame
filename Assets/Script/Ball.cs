using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float speed ;
    void Start()
    {
        rb.AddForce(Vector3.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
