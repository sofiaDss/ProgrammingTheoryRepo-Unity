using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuManagment : MonoBehaviour
{
    //GameObjects
    public TMP_InputField inputName;
    public Toggle inputIsCat;
    public Toggle inputIsDog;

    //Variables

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inputIsCat)
        {
            inputIsDog.isOn = false;
        }
        if (inputIsDog)
        {
            inputIsCat.isOn = false;
        }
    }

    public void StartGame()
    {
        if (inputName.text != "" && ((inputIsCat && inputIsDog!)||(inputIsCat! && inputIsDog)))
        {
            UserData.Instance.userName = inputName.text;
            UserData.Instance.isCat = inputIsCat ? true : false;
            SceneManager.LoadScene(1);
        }
    }
}
