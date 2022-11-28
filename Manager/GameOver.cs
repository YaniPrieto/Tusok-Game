using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] UnityEvent GameOverEvent;
    void Start()
    {
        EventManager.instance.onTriggerGameOver += SetGameOver;
    }

    void SetGameOver()
    {
        Debug.Log("Trigger");
        SoundManager.instance.Stop("GameMusic");
        SoundManager.instance.Play("GameOver");
        GameOverEvent.Invoke();
    }
    private void OnDisable()
    {
        EventManager.instance.onTriggerGameOver -= SetGameOver;
    }
}
