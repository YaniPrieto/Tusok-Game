using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Proyecto26;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AccountManager : MonoBehaviour
{
    public UIAccountManager uam;
    [SerializeField] string URL;
    public void Login()
    {
        string username = uam.userNameField.text;
        string password = uam.passwordField.text;
        string uri = URL + "/CheckCredentials";
        RestClient.Request(new RequestHelper()
        {
            Uri = uri,
            Method = "POST",
            Timeout = 20,
            Retries = 5,
            SimpleForm = new Dictionary<string, string>()
            {
                {"username", username},
                {"password", password}
            },
            ContentType = "application/x-www-form-urlencoded",
        }).Then(response =>
        {
            uam.infoPrompt.text = "Login successful";
            PlayerData playerData = JsonConvert.DeserializeObject<PlayerData>(response.Text);
            PlayerPrefs.SetString("username", username);
            PlayerPrefs.SetInt("highscore", playerData.score);
            SceneManager.LoadScene("Main Menu");
        }, error =>
        {
            Debug.Log("Wrong Username or Password");
            uam.infoPrompt.text = "Wrong Username or Password";
        });
 }
    public void Register()
    {
        string username = uam.userNameField.text;
        string password = uam.passwordField.text;
        PlayerData player = new PlayerData();
        player.username = username;
        player.score = 0;

        string uri = URL + "/RegisterNewPlayer";

        RestClient.Request(new RequestHelper()
        {
            Uri = uri,
            Method = "POST",
            Timeout = 20,
            Retries = 5,
            SimpleForm = new Dictionary<string, string>()
            {
                {"username", username },
                {"password", password }
            },
            ContentType = "application/x-www-form-urlencoded"
        }).Then(response =>
        {
            Debug.Log("Registration Successful");
            PlayerPrefs.SetString("username", username);
            uam.infoPrompt.text = "Registration Successful";
        }, error =>
        {
            Debug.Log("Username already taken.");
            uam.infoPrompt.text = "Username already taken.";
        });
    }
}
