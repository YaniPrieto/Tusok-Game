using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class QuitApple : Fruit
{
    [SerializeField] GameObject particle;
    [SerializeField] SpriteRenderer renderer;
    [SerializeField] CircleCollider2D collider;


    public override void Die()
    {
        SoundManager.instance.Play("HitApple");
        Instantiate(particle, transform.position, transform.rotation);
        StartCoroutine(QuitGame());
    }
    IEnumerator QuitGame()
    {
        renderer.enabled = false;
        collider.enabled = false;
        yield return new WaitForSeconds(1);
        Debug.Log("Quit");
        Application.Quit();
    }
}
