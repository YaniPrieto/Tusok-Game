using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Fruit fruit;
        fruit = other.gameObject.GetComponent<Fruit>();

        if (other.tag == "Fruit")
        {
            fruit.Die();
        }
    }
}