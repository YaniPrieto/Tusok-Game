using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.Play("GameMusic");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
