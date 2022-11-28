using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class StartApple : Fruit
{
    [SerializeField]
    GameObject particle;
    [SerializeField]
    Animator transitionAnim;
    [SerializeField]
    SpriteRenderer sprite;
    [SerializeField]
    CircleCollider2D collider;
    public override void Die()
    {
        SoundManager.instance.Play("HitApple");
        Instantiate(particle, transform.position, transform.rotation);
        StartCoroutine(GameStart());
    }
    IEnumerator GameStart()
    {
        transitionAnim.SetTrigger("end");
        collider.enabled = false;
        sprite.enabled = false;

        yield return new WaitForSeconds(5f);
        SoundManager.instance.Stop("BGM");
        SoundManager.instance.Stop("GrassHopper");
        SceneManager.LoadScene("SampleScene");
    }
}
