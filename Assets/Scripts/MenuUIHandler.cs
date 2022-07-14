using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif


// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
//[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{

    public TMP_InputField nameInputField;


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void OnEndEdit()
    {

    }


    public void UpdateName()
    {
        DataManager.Instance.NameText = nameInputField.text;
    }




    public void Exit()
    {



#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
