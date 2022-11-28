using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Reference Variables")]
    public static Spawner instance;
    private List<GameObject> pooledObjects = new List<GameObject>();
    [SerializeField]
    private int amountToPool = 5;

    [Header("Fruit Game Objects")]
    [SerializeField] GameObject pattern01;
    [SerializeField] GameObject pattern02;
    [SerializeField] GameObject pattern03;
    [SerializeField] GameObject pattern04;
    [SerializeField] GameObject pattern05;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject pat1 = Instantiate(pattern01);
            GameObject pat2 = Instantiate(pattern02);
            GameObject pat3 = Instantiate(pattern03);
            GameObject pat4 = Instantiate(pattern04);
            GameObject pat5 = Instantiate(pattern05);
            pat1.SetActive(false);
            pat2.SetActive(false);
            pat3.SetActive(false);
            pat4.SetActive(false);
            pat5.SetActive(false);
            pooledObjects.Add(pat1);
            pooledObjects.Add(pat2);
            pooledObjects.Add(pat3);
            pooledObjects.Add(pat4);
            pooledObjects.Add(pat5);


        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

}
