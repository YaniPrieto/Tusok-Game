using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{

    // ======================================================
    [Header("Spawner Variables")]
    [SerializeField] float spawnTime;
    [SerializeField] float currentTime;
    [SerializeField] int fruitCountSpawn;
    [SerializeField] float spawnDelay;

    // ======================================================
    [Header("Barrier Spawn")]
    [SerializeField] float min_X;
    [SerializeField] float max_X;
    // ======================================================
    [Header("Reference")]
    public static FruitSpawner instance;
    public ObjectPool objectPooler;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentTime = spawnTime;
    }
    void FixedUpdate()
    {
        FruitSpawn();
    }
    void FruitSpawn()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= spawnTime)
        {
            fruitCountSpawn++;
            Vector3 temp = transform.position;
            Vector3 euler = transform.eulerAngles;
            euler.z = Random.Range(0, 90);
            temp.y = 7f;
            GameObject newFruit = null;

            if (fruitCountSpawn < 3)
            {
                temp.x = Random.Range(min_X, max_X);
                newFruit = objectPooler.pattern01Spawn();
                newFruit.transform.position = temp;
                newFruit.transform.eulerAngles = euler;
                newFruit.SetActive(true);
            }
            else if (fruitCountSpawn == 2)
            {
                if (Random.Range(0, 2) > 0)
                {
                    temp.x = Random.Range(min_X, max_X);
                    newFruit = objectPooler.pattern01Spawn();
                    newFruit.transform.position = temp;
                    newFruit.transform.eulerAngles = euler;
                    newFruit.SetActive(true);
                }
                else
                {
                    temp.x = Random.Range(min_X, max_X);
                    newFruit = objectPooler.pattern02Spawn();
                    newFruit.transform.position = temp;
                    newFruit.transform.eulerAngles = euler;
                    newFruit.SetActive(true);
                }
            }
            else if (fruitCountSpawn == 3)
            {
                if (Random.Range(0, 10) == 1)
                {
                    temp.x = Random.Range(min_X, max_X);
                    newFruit = objectPooler.pattern04Spawn();
                    newFruit.transform.position = temp;
                    newFruit.transform.eulerAngles = euler;
                    newFruit.SetActive(true);
                }
                else if (Random.Range(0, 4) == 2)
                {
                    temp.x = Random.Range(min_X, max_X);
                    newFruit = objectPooler.pattern05Spawn();
                    newFruit.transform.position = temp;
                    newFruit.transform.eulerAngles = euler;
                    newFruit.SetActive(true);
                }
                else
                {
                    temp.x = Random.Range(min_X, max_X);
                    newFruit = objectPooler.pattern03Spawn();
                    newFruit.transform.position = temp;
                    newFruit.transform.eulerAngles = euler;
                    newFruit.SetActive(true);
                }
                fruitCountSpawn = 0;
            }
            currentTime = 0f;
        }
    }
    void IncreaseSpeed()
    {
        if (spawnTime <= 1f)
        {
            return;
        }
        else
        {
            spawnTime = spawnTime - 0.25f;
        }

    }
    public void Progress()
    {
        if (ScoreManager.instance.scoreCounter == 10)
        {
            SoundManager.instance.Play("SuccessSound");
            Debug.Log("Trigger: " + ScoreManager.instance.scoreCounter);
            ScoreManager.instance.scoreCounter = 0;
            IncreaseSpeed();
        }
    }

}
