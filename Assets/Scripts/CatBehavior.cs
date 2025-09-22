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
            if (value < 0.0f){ jumpForce = 0; }
            else{ jumpForce = value; }
        }
    }

    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
