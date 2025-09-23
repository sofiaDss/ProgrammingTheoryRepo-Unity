using UnityEngine;

// INHERITANCE
public class DogBehavior : Animal
{
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
            AvoidObstacle(null,0.0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        modifyLife(collision, mainManager);
    }

    // POLYMORPHISM
    protected override void AvoidObstacle(GameObject playerRb, float jumpForce)
    {
        Debug.Log("Dogs can push walls!");
    }
}
