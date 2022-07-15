using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreUIHandler : MonoBehaviour
{
    public TMP_Text highScoreNameText;
    public TMP_Text highScoreScoreText;

    void Start()
    {
        HighScorePageText();
        DataManager.Instance.LoadHighScore();
    }


    public void HighScorePageText()
    {

        highScoreNameText.text = DataManager.Instance.HighScoreName[0] + "\n" + DataManager.Instance.HighScoreName[1] +
                          "\n" + DataManager.Instance.HighScoreName[2] + "\n" + DataManager.Instance.HighScoreName[3] +
                          "\n" + DataManager.Instance.HighScoreName[4] + "\n" + DataManager.Instance.HighScoreName[5] +
                          "\n" + DataManager.Instance.HighScoreName[6] + "\n" + DataManager.Instance.HighScoreName[7] +
                          "\n" + DataManager.Instance.HighScoreName[8] + "\n" + DataManager.Instance.HighScoreName[9];

        highScoreScoreText.text = DataManager.Instance.HighScore[0] + "\n" + DataManager.Instance.HighScore[1] +
                          "\n" + DataManager.Instance.HighScore[2] + "\n" + DataManager.Instance.HighScore[3] +
                          "\n" + DataManager.Instance.HighScore[4] + "\n" + DataManager.Instance.HighScore[5] +
                          "\n" + DataManager.Instance.HighScore[6] + "\n" + DataManager.Instance.HighScore[7] +
                          "\n" + DataManager.Instance.HighScore[8] + "\n" + DataManager.Instance.HighScore[9];
    }

}
