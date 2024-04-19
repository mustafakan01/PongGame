using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{
    public float speed;
    public float limitHorizontal=2.2f;
    public bool isUp;
    [SerializeField] private bool isPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 newPoz=transform.position;
        if (isPlayer)
        {
            var input = Input.GetAxis("Horizontal");

            newPoz = transform.position + (Vector3.right * (input * speed * Time.deltaTime));
           
        }
        else 
        {
            var ai = Ball.Instance.transform.position.x;
            newPoz.x = ai;
        }

        newPoz.x = Mathf.Clamp(newPoz.x, -limitHorizontal, limitHorizontal);

        transform.position = newPoz;



    }
}
