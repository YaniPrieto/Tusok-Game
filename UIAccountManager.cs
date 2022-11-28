using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIAccountManager : MonoBehaviour
{
    [Header("Input Fields & Buttons")]
    public TMP_InputField passwordField;
    public TMP_InputField userNameField;
    public Button loginButton;
    public Button registerButton;
    public TMP_Text infoPrompt;
    private UIAccountManager instance;

    private void Awake()
    {
        instance = this;
    }
}
