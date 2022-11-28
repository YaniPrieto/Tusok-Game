using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigApple : Fruit
{

    [SerializeField] GameObject particle;
    public override void Start()
    {
        base.Start();
    }
    public override void Die()
    {
        SoundManager.instance.Play("HitApple");
        ScoreManager.instance.AddPoint();
        Instantiate(particle, transform.position, transform.rotation);
    }
    public override void Despawn()
    {
        ScoreManager.instance.GameOver();
        base.Despawn();
    }
}
