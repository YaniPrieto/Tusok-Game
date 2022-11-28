using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    public override void Start()
    {
        base.Start();
    }
    public override void Die()
    {
        GameObject particle = null;
        SoundManager.instance.Play("HitApple");
        ScoreManager.instance.AddPoint();
        // Instantiate(particle, transform.position, transform.rotation);
        particle = ParticlePool.instance.SpawnAppleParticle();
        particle.transform.position = transform.position;
        particle.SetActive(true);

        base.Die();
    }
    public override void Despawn()
    {
        EventManager.instance.gameOver();
    }
}
