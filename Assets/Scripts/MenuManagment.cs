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

    public void StartGame()
    {
        if (inputName.text != "" && (inputIsCat.isOn ^ inputIsDog.isOn))
        {
            UserExperience.Instance.userName = inputName.text;
            UserExperience.Instance.isCat = inputIsCat.isOn ? true : false;
            SceneManager.LoadScene(1);
        }
    }
}
