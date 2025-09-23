using UnityEngine;

public class UserExperience : MonoBehaviour
{
    public static UserExperience Instance;

    //Variables
    public string userName;
    public bool isCat;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
