using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxSpeed;
    private Vector3 startPosition;

    void Start()
    {
        maxSpeed = 3;
        
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("You Lose");

            other.transform.position = new Vector3(17,1,-11.3f);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }


}
