﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserManager : MonoBehaviour {

    public InputField usernameField;
    public InputField passwordField;
    public Button submitButton;
    public Text submitButtonText;
    private void Start()
    {
        submitButtonText = submitButton.GetComponentInChildren<Text>();
    }
    public void ResetSubmitText()
    {
        submitButtonText.text = "Play";
    }

    public void CallLogin()
    {
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", usernameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://u484157030.hostingerapp.com/login.php", form);
        yield return www;
        if (www.text.StartsWith("Valid"))
        {
            DBManager.username = usernameField.text;
            SaveSystem.Instance.LoadPlayer();
            SceneFader.Instance.FadeTo("MainMenu");
        }
        else
        {
            Debug.Log("User login failed. Error: " + www.text);
            submitButtonText.text = "<color=#A00000>Incorrect password</color>";
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = usernameField.text.Length > 4 && passwordField.text.Length > 4;
    }
}
