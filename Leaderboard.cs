using UnityEngine;
using TMPro;
using LootLocker.Requests;
using System.Collections;

public class Leaderboard : MonoBehaviour
{
    public int ID;
    public static Leaderboard instance;
    public TMP_InputField MemberID;
    string playerIdentifier = "unique_player_identifier_here";
    int maxScores = 6;
    public TMP_Text[] entries;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //Debug.Log("Player Score: " + ScoreManager.instance.score);
        //LootLockerSDKManager.StartSession(playerIdentifier, (response) =>
        // {
        //     if (response.success)
        //     {
        //         Debug.Log("Success");
        //     }
        //     else
        //     {
        //         Debug.Log("failed to start sessions" + response.Error);
        //     }
        // });
    }
    public void SubmitScore()
    {
        LootLockerSDKManager.SubmitScore(MemberID.text, ScoreManager.instance.score, ID, (response) => 
        {
            if (response.success)
            {
                Debug.Log(MemberID.text+ " Success");
            }
            else
            {
                Debug.Log("failed to start sessions" + response.Error);
            }
        });
    }

    public IEnumerator LeaderboardScore()
    {
        bool done = false;
        LootLockerSDKManager.GetScoreListMain(ID, 10, 0, (response) =>
           {
               if (response.success)
               {
                   string tempPlayerNames = "Names\n";
                   string tempPlayerScores = "Scores\n";

                   LootLockerLeaderboardMember[] members = response.items;

                   for (int i = 0; i < members.Length; i++)
                   {
                       tempPlayerNames += members[i].rank + ". ";
                       if (members[i].player.name != "")
                       {
                           tempPlayerNames += members[i].player.name;
                       }
                       else
                       {
                           tempPlayerNames += members[i].player.id;
                       }
                       tempPlayerScores += members[i].score + "\n";
                       tempPlayerNames += "\n";
                   }
                   done = true;
               }
               else
               {
                   Debug.Log("Failed" + response.Error);
                   done = true;
               }
           });
        yield return new WaitWhile(() => done == false);
    }
}
