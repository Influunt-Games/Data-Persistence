using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
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

    [System.Serializable]
    class SaveData
    {
        public int[] HighScore;
        public string[] HighScoreName;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.HighScore = HighScore;
        data.HighScoreName = HighScoreName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }



}   

