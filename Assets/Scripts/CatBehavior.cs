using System;
using System.Data;
using UnityEngine;

// INHERITANCE
public class CatBehavior : Animal
{
    // ENCAPSULATION
    private float verticalInput;
    private float jumpForce;
    public float jump_Force
    {
        get { return jumpForce; }
        set
        {
            if (value < 0.0f) { jumpForce = 0; }
            else { jumpForce = value; }
        }
    }
    void Start()
    {
        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Move(horizontalInput);
        AvoidObstacle(verticalInput);
    }

    void OnCollisionEnter(Collision collision)
    {
        modifyLife(collision, mainManager);
        if (collision.gameObject.CompareTag("Wall"))
        {
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
    }

    // POLYMORPHISM
    protected override void AvoidObstacle(float verticalInput)
    {
        Debug.Log("The cat can only jump over walls!");
        base.AvoidObstacle(verticalInput);
    }

}
