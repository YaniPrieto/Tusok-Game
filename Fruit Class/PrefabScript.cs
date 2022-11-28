using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : Fruit
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] fruits;
    [SerializeField] Transform[] fruitPos;

    [SerializeField] Transform[] TransHolder;
    bool triggered;

    void Awake()
    {
        if (!triggered)
        {
            GetPosition();
            triggered = true;
        }
    }
    IEnumerator Start()
    {

        for (int i = 0; i < fruits.Length; i++)
        {
            fruits[i].SetActive(true);
            fruits[i].transform.position = TransHolder[i].position;
        }
        yield return new WaitForSeconds(5f);

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void GetPosition()
    {
        for (int i = 0; i < fruits.Length; i++)
        {
            Debug.Log("fruits length: " + fruits.Length);
            Debug.Log("trans holder length: " + TransHolder.Length);
            TransHolder[i].transform.position = fruitPos[i].transform.position;
        }
    }
}
