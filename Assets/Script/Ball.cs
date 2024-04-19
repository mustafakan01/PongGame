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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("RacketUp"))
        {
            var racket=other.transform.gameObject.GetComponent<RacketController>();
            var directionVertical = racket.isUp ? -1 : 1;
            var directionHorizontal= (transform.position.x - racket.transform.position.x);

            rb.AddForce(new Vector2 (directionVertical, directionHorizontal));
        }
        if (other.transform.CompareTag("RacketDown"))
        {
            rb.AddForce(Vector3.up * speed);
        }
    }
}
