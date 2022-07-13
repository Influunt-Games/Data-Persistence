using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    
    public TMP_InputField inputField;
    public string NameText;

    public Text BestScoreText;
    public string[] HighScoreName;
    public int[] HighScore;

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


    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    UpdateName();
        //    Debug.Log(NameText);
        //}
       
    }



   // public void UpdateName()
   // {
   //     NameText = inputField.text;
   //
   // }
}
