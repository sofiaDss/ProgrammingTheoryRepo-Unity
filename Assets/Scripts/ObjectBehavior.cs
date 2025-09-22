using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    //Variables
    public float addLife;
    public bool isPartnerCat;
    public bool isPartnerDog;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
