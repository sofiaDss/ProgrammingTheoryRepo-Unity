using System;
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

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        Move(inputHorizontal);
    }

    void OnCollisionEnter(Collision collision)
    {
        modifyLife(collision, mainManager);
    }

    // POLYMORPHISM

}
