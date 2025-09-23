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
        inputHorizontal = Input.GetAxis("Horizontal");
        Move(inputHorizontal);
    }

    void OnCollisionEnter(Collision collision)
    {
        modifyLife(collision, mainManager);
    }
}
