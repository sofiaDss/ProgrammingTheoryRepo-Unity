using UnityEngine;

// INHERITANCE
public class Animal : MonoBehaviour
{
    //Variables
    [SerializeField] protected float life;
    [SerializeField] protected float speed;
    [SerializeField] protected Rigidbody animalRb;

    public void ModifyLife(float addLife)
    {
        life += addLife;
    }

    public void Move()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.up * speed * inputHorizontal *  Time.deltaTime);
    }


    // POLYMORPHISM
    public virtual void AvoidObstacle()
    {   

    }

}
