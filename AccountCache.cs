using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using Proyecto26;
using TMPro;

public class AccountCache : MonoBehaviour
{
    public TMP_Text welcomeText;
    public string GET_URL;
   void Start()
    {
       welcomeText.text = "Welcome "+ PlayerPrefs.GetString("username");
        Debug.Log(PlayerPrefs.GetString("username"));
        Debug.Log(PlayerPrefs.GetInt("highscore"));
    }
}
