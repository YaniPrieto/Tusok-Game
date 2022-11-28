using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottenApple : Fruit
{
    [SerializeField] GameObject particle;

    public override void Start()
    {
        base.Start();
    }
    public override void Die()
    {
        SoundManager.instance.Play("RotHit");
        ScoreManager.instance.MinusPoint();
        GameObject particle = null;
        particle = ParticlePool.instance.SpawnRottenParticle();
        particle.transform.position = transform.position;
        particle.SetActive(true);
        base.Die();
    }
    public override void Despawn()
    {
        base.Despawn();
    }

}
