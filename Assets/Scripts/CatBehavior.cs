using System;
using System.Data;
using UnityEngine;

// INHERITANCE
public class CatBehavior : Animal
{
    // ENCAPSULATION
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

    void Update()
    {
        if (mainManager.isGameActive)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            Move(horizontalInput);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AvoidObstacle(gameObject, jumpForce);
            }
        }
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
    protected override void AvoidObstacle(GameObject playerRb, float jumpForce)
    {
        Debug.Log("The cat can only jump over walls!");
        base.AvoidObstacle(playerRb, jumpForce);
    }

}
