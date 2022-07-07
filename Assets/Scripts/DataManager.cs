using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public Text BestScoreText;
    public GameObject NameTextGO;
    //public string NameText;
    public Text NameText;
    public int HighScore;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateName();
            Debug.Log(NameText);
        }
       
    }
    

    public void UpdateName()
    {
        //NameText = NameTextGO.GetComponent<TextMeshPro>().text;
        string userID = NameText.text.ToString();
    }
}
