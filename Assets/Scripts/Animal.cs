using UnityEngine;
//3. Activar el game Over


// INHERITANCE
public class Animal : MonoBehaviour
{
    //Variables
    protected MainManager mainManager;
    protected float horizontalInput;
    [SerializeField] protected float speed;
    [SerializeField] protected GameObject partnerObject;
    [SerializeField] protected GameObject enemyObject;

    protected void Move(float horizontalInput)
    {
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
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
    protected virtual void AvoidObstacle(GameObject playerRb, float jumpForce)
    {
        playerRb.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
