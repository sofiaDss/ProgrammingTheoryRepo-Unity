using UnityEngine;
//1. Cada animal debe ganar o perder vida con sus objetos
//2. Cada animal debe interactuar con Wall: perro debe empujar y gato debe saltar.
//3. Activar el game Over
//4. Craer y Activar el ¡Victory!


// INHERITANCE
public class Animal : MonoBehaviour
{
    //Variables
    protected MainManager mainManager;
    protected float inputHorizontal;
    [SerializeField] protected float speed;
    [SerializeField] protected GameObject partnerObject;
    [SerializeField] protected GameObject enemyObject;

    protected void Move(float inputHorizontal)
    {
        transform.Translate(Vector3.right * speed * inputHorizontal * Time.deltaTime);
    }

    protected void modifyLife(Collision collision, MainManager mainManager)
    {
        if (collision.gameObject.CompareTag(partnerObject.tag))
        {
            mainManager.totalLife += partnerObject.GetComponent<ObjectBehavior>().addLife;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(enemyObject.tag))
        {
            mainManager.totalLife -= enemyObject.GetComponent<ObjectBehavior>().addLife;
            Destroy(collision.gameObject);
        }
    }

    // POLYMORPHISM
    protected virtual void AvoidObstacle()
    {


    }
    

}
