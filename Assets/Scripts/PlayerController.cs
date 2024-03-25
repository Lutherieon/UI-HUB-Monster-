using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float horizontalInput;
    float verticalInput;
    [SerializeField] float speed = 1.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3 (horizontalInput * speed * Time.deltaTime, rb.velocity.y,verticalInput * speed * Time.deltaTime);
    }
}
