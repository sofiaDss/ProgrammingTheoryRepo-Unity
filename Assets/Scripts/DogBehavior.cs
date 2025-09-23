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
        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Move(horizontalInput);
        AvoidObstacle(0.0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        modifyLife(collision, mainManager);
    }

    // POLYMORPHISM
    protected override void AvoidObstacle(float verticalInput)
    {
        Debug.Log("Dogs can push walls!");
    }
}
