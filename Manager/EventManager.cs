using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Events;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;
    private void Awake()
    {
        instance = this;
    }
    public event Action onTriggerGameOver;

    public void gameOver()
    {
        if (onTriggerGameOver != null)
        {
            onTriggerGameOver();
        }
    }


}
