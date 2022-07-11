using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public  Text BestScoreText;
    public GameObject NameTextGO;
    public static string NameText;
    //public Text NameText;
    public static int HighScore;

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
        NameTextGO = GameObject.Find("Name Text");
        NameText = NameTextGO.GetComponent<TextMeshPro>().text.ToString();
        
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

         
        //string userID = NameText.text.ToString();
    }
}
