using UnityEngine;

// INHERITANCE
public class DogBehavior : Animal
{
    // ENCAPSULATION
    private float thrustForce;
    public float thrust_Force
    {
        get { return thrustForce; }
        set { thrustForce = value; }
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
