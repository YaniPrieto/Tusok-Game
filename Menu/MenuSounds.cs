using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.Play("BatFly");
        SoundManager.instance.Play("BGM");
    }
    public IEnumerator GrassHoper()
    {
        yield return new WaitForSeconds(5f);
        SoundManager.instance.Play("GrassHopper");
    }

    // Update is called once per frame
}
