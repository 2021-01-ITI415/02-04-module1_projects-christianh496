using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{

    public float speed = 0f;
    public Rigidbody rb;
    
    public float horizontal;
    public float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    
    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        Vector3 direction = new Vector3(- vertical, 0.0f, horizontal);



        rb.AddForce(direction * speed);



    }
}
