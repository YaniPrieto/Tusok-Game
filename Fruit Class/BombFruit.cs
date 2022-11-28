using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFruit : Fruit
{
    [SerializeField] GameObject particle;
    Rigidbody2D rb;
    public override void Start()
    {

        SoundManager.instance.Play("BombSound");
    }
    public override void Die()
    {
        SoundManager.instance.Play("BombHit");
        EventManager.instance.gameOver();
        Instantiate(particle, transform.position, transform.rotation);
        base.Die();
    }
    public override void Despawn()
    {
        base.Despawn();
    }
}
