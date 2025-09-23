using UnityEngine;

// INHERITANCE
public class Animal : MonoBehaviour
{
    //Variables
    [SerializeField] protected float life;
    [SerializeField] protected float speed;
    [SerializeField] protected Rigidbody animalRb;
    [SerializeField] protected GameObject partnerObject;

    protected void ModifyLife(float addLife)
    {
        life += addLife;
    }

    protected void Move()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.up * speed * inputHorizontal *  Time.deltaTime);
    }

    // POLYMORPHISM
    protected virtual void AvoidObstacle()
    {

    }

}
