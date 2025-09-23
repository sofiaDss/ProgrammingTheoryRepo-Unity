using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    //Variables
    [SerializeField] private TMP_Text userNameText;
    [SerializeField] private TMP_Text userLifeText;
    [SerializeField] private GameObject[] animalPrefabs;
    public bool isCat;
    public float totalLife = 50.0f;

    void Start()
    {
        isCat = UserExperience.Instance.isCat;
        userNameText.text = isCat ? $"{UserExperience.Instance.userName}'s Cat" : $"{UserExperience.Instance.userName}'s Dog";
        userLifeText.text = $"Life: {totalLife} %";
        selectAnimal();        
    }
    void Update()
    {
        userLifeText.text = $"Life: {totalLife} %";        
    }


    void selectAnimal()
    {
        int animalIndex;
        if (animalPrefabs.Length > 0)
        {
            animalIndex = isCat ? 0 : 1;
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, -9, -1.2f), animalPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
