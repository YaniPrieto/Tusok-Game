using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderboardList : MonoBehaviour
{
    public TMP_Text rankText;
    public TMP_Text usernameText;
    public TMP_Text scoreText;
    public void CreateEntry(string rank, string username, string score)
    {
        rankText.text = "#" + rank;
        usernameText.text = username;
        scoreText.text = score;
    }
}
