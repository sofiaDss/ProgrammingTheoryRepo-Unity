using UnityEngine;

public class UserData : MonoBehaviour
{
    public static UserData Instance;

    //Variables
    public string userName;
    public bool isCat;

    // Store data between screens
    private void Awake(){
        if(Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
