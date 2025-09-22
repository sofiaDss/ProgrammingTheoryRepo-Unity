using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    //Variables
    [SerializeField] private TMP_Text userNameText;
    [SerializeField] private TMP_Text userLifeText;
    private bool isCat;
    public float totalLife = 50.0f;

    void Start()
    {
        isCat = UserExperience.Instance.isCat;
        userNameText.text = isCat ? $"{UserExperience.Instance.userName}'s Cat" : $"{UserExperience.Instance.userName}'s Dog";
        userLifeText.text = $"Life: {totalLife} %";
    }
}
