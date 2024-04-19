using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{
    public float speed;
    public float limitHorizontal=2.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var input = Input.GetAxis("Horizontal");

        var newPoz=transform.position + (Vector3.right * (input *speed * Time.deltaTime));
        newPoz.x = Mathf.Clamp(newPoz.x, -limitHorizontal, limitHorizontal);

        transform.position = newPoz;
    }
}
