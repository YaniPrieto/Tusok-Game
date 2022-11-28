using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fruit : MonoBehaviour
{


    //Singleton use
    public virtual void Start()
    {
        SoundManager.instance.Play("Throw");
    }
    public virtual void Die()
    {
        gameObject.SetActive(false);
    }
    public virtual void Despawn()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Despawner")
        {
            Despawn();
        }
    }

}
