
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{

    public Brick BrickPrefab;
    public int LineCount = 6;
    public Rigidbody Ball;

    public Text ScoreText;
    public Text bestScoreText;
    public GameObject GameOverText;
    
    private bool m_Started = false;
    private int m_Points;
    
    private bool m_GameOver = false;
    public int highScore;



    // Start is called before the first frame update
    void Start()
    {
        const float step = 0.6f;
        int perLine = Mathf.FloorToInt(4.0f / step);
        
        int[] pointCountArray = new [] {1,1,2,2,5,5};
        for (int i = 0; i < LineCount; ++i)
        {
            for (int x = 0; x < perLine; ++x)
            {
                Vector3 position = new Vector3(-1.5f + step * x, 2.5f + i * 0.3f, 0);
                var brick = Instantiate(BrickPrefab, position, Quaternion.identity);
                brick.PointValue = pointCountArray[i];
                brick.onDestroyed.AddListener(AddPoint);
            }
        }

        bestScoreText.text = "Best Score : " + DataManager.Instance.HighScoreName[0] + " : " + DataManager.Instance.HighScore[0];
    }

    private void Update()
    {
        if (!m_Started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Started = true;
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDir = new Vector3(randomDirection, 1, 0);
                forceDir.Normalize();

                Ball.transform.SetParent(null);
                Ball.AddForce(forceDir * 2.0f, ForceMode.VelocityChange);
            }
        }
        else if (m_GameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    void AddPoint(int point)
    {
        m_Points += point;
        ScoreText.text = $"Score : {m_Points}";
    }

    public void GameOver()
    {

        m_GameOver = true;
        GameOverText.SetActive(true);
        HighScore();
        DataManager.Instance.SaveHighScore();
    }

    public void NewNameSelected(Text text)
    {

    }

    public void HighScore()
    {

        int higher;
        int lower;

        string higherName;
        string lowerName;

        highScore = m_Points;


            if (highScore > DataManager.Instance.HighScore[9])
            {
                DataManager.Instance.HighScoreName[9] = DataManager.Instance.NameText;
                DataManager.Instance.HighScore[9] = highScore;
            }
            
            if(DataManager.Instance.HighScore[9] > DataManager.Instance.HighScore[8])
            {
                lower = DataManager.Instance.HighScore[8];
                higher = DataManager.Instance.HighScore[9];

                DataManager.Instance.HighScore[8] = higher;
                DataManager.Instance.HighScore[9] = lower;

                lowerName = DataManager.Instance.HighScoreName[8];
                higherName = DataManager.Instance.HighScoreName[9];

                DataManager.Instance.HighScoreName[8] = higherName;
                DataManager.Instance.HighScoreName[9] = lowerName;
        }

            if (DataManager.Instance.HighScore[8] > DataManager.Instance.HighScore[7])
            {
               lower = DataManager.Instance.HighScore[7];
               higher = DataManager.Instance.HighScore[8];

               DataManager.Instance.HighScore[7] = higher;
               DataManager.Instance.HighScore[8] = lower;

               lowerName = DataManager.Instance.HighScoreName[7];
               higherName = DataManager.Instance.HighScoreName[8];

               DataManager.Instance.HighScoreName[7] = higherName;
               DataManager.Instance.HighScoreName[8] = lowerName;
             }

        if (DataManager.Instance.HighScore[7] > DataManager.Instance.HighScore[6])
        {
            lower = DataManager.Instance.HighScore[6];
            higher = DataManager.Instance.HighScore[7];

            DataManager.Instance.HighScore[6] = higher;
            DataManager.Instance.HighScore[7] = lower;

            lowerName = DataManager.Instance.HighScoreName[6];
            higherName = DataManager.Instance.HighScoreName[7];

            DataManager.Instance.HighScoreName[6] = higherName;
            DataManager.Instance.HighScoreName[7] = lowerName;
        }

        if (DataManager.Instance.HighScore[6] > DataManager.Instance.HighScore[5])
        {
            lower = DataManager.Instance.HighScore[5];
            higher = DataManager.Instance.HighScore[6];

            DataManager.Instance.HighScore[5] = higher;
            DataManager.Instance.HighScore[6] = lower;

            lowerName = DataManager.Instance.HighScoreName[5];
            higherName = DataManager.Instance.HighScoreName[6];

            DataManager.Instance.HighScoreName[5] = higherName;
            DataManager.Instance.HighScoreName[6] = lowerName;
        }

        if (DataManager.Instance.HighScore[5] > DataManager.Instance.HighScore[4])
        {
            lower = DataManager.Instance.HighScore[4];
            higher = DataManager.Instance.HighScore[5];

            DataManager.Instance.HighScore[4] = higher;
            DataManager.Instance.HighScore[5] = lower;

            lowerName = DataManager.Instance.HighScoreName[4];
            higherName = DataManager.Instance.HighScoreName[5];

            DataManager.Instance.HighScoreName[4] = higherName;
            DataManager.Instance.HighScoreName[5] = lowerName;
        }

        if (DataManager.Instance.HighScore[4] > DataManager.Instance.HighScore[3])
        {
            lower = DataManager.Instance.HighScore[3];
            higher = DataManager.Instance.HighScore[4];

            DataManager.Instance.HighScore[3] = higher;
            DataManager.Instance.HighScore[4] = lower;

            lowerName = DataManager.Instance.HighScoreName[3];
            higherName = DataManager.Instance.HighScoreName[4];

            DataManager.Instance.HighScoreName[3] = higherName;
            DataManager.Instance.HighScoreName[4] = lowerName;
        }

        if (DataManager.Instance.HighScore[3] > DataManager.Instance.HighScore[2])
        {
            lower = DataManager.Instance.HighScore[2];
            higher = DataManager.Instance.HighScore[3];

            DataManager.Instance.HighScore[2] = higher;
            DataManager.Instance.HighScore[3] = lower;

            lowerName = DataManager.Instance.HighScoreName[2];
            higherName = DataManager.Instance.HighScoreName[3];

            DataManager.Instance.HighScoreName[2] = higherName;
            DataManager.Instance.HighScoreName[3] = lowerName;
        }

        if (DataManager.Instance.HighScore[2] > DataManager.Instance.HighScore[1])
        {
            lower = DataManager.Instance.HighScore[1];
            higher = DataManager.Instance.HighScore[2];

            DataManager.Instance.HighScore[1] = higher;
            DataManager.Instance.HighScore[2] = lower;

            lowerName = DataManager.Instance.HighScoreName[1];
            higherName = DataManager.Instance.HighScoreName[2];

            DataManager.Instance.HighScoreName[1] = higherName;
            DataManager.Instance.HighScoreName[2] = lowerName;
        }

        if (DataManager.Instance.HighScore[1] > DataManager.Instance.HighScore[0])
        {
            lower = DataManager.Instance.HighScore[0];
            higher = DataManager.Instance.HighScore[1];

            DataManager.Instance.HighScore[0] = higher;
            DataManager.Instance.HighScore[1] = lower;

            lowerName = DataManager.Instance.HighScoreName[0];
            higherName = DataManager.Instance.HighScoreName[1];

            DataManager.Instance.HighScoreName[0] = higherName;
            DataManager.Instance.HighScoreName[1] = lowerName;
        }


        bestScoreText.text = "Best Score : " + DataManager.Instance.HighScoreName[0] + " : " + DataManager.Instance.HighScore[0];

        
    }

}
