using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{

    //Variables
    [SerializeField] private float addLife;

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Wall"))
        {
            if (collision.gameObject.CompareTag("WallLeft") || collision.gameObject.CompareTag("WallRight"))
            {
                Destroy(gameObject);
            }
        }
        else
        {
            if (collision.gameObject.CompareTag("WallDown"))
            {
                Destroy(gameObject);
            }
        }
    }
}
