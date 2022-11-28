using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [Header("Game Object Variables")]
    [SerializeField] GameObject pattern1;
    [SerializeField] GameObject pattern2;
    [SerializeField] GameObject pattern3;
    [SerializeField] GameObject pattern4;
    [SerializeField] GameObject pattern5;

    [Header("Fields")]
    [SerializeField] int amountToPool;

    [Header("List")]
    List<GameObject> patPoolObj1 = new List<GameObject>();
    List<GameObject> patPoolObj2 = new List<GameObject>();
    List<GameObject> patPoolObj3 = new List<GameObject>();
    List<GameObject> patPoolObj4 = new List<GameObject>();
    List<GameObject> patPoolObj5 = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < amountToPool; i++)
        {
            //pat is short for pattern1
            GameObject pat1 = (GameObject)Instantiate(pattern1);
            pat1.SetActive(false);
            patPoolObj1.Add(pat1);

            GameObject pat2 = (GameObject)Instantiate(pattern2);
            pat2.SetActive(false);
            patPoolObj2.Add(pat2);


            GameObject pat3 = (GameObject)Instantiate(pattern3);
            pat3.SetActive(false);
            patPoolObj3.Add(pat3);

            GameObject pat4 = (GameObject)Instantiate(pattern4);
            pat4.SetActive(false);
            patPoolObj4.Add(pat4);

            GameObject pat5 = (GameObject)Instantiate(pattern5);
            pat5.SetActive(false);
            patPoolObj5.Add(pat5);

        }
    }
    public GameObject pattern01Spawn()
    {
        for (int i = 0; i < patPoolObj1.Count; i++)
        {
            if (!patPoolObj1[i].activeInHierarchy)
            {
                return patPoolObj1[i];
            }
        }
        GameObject pat1 = (GameObject)Instantiate(pattern1);
        pat1.SetActive(false);
        patPoolObj1.Add(pat1);
        return pat1;
    }
    public GameObject pattern02Spawn()
    {
        for (int i = 0; i < patPoolObj2.Count; i++)
        {
            if (!patPoolObj2[i].activeInHierarchy)
            {
                return patPoolObj2[i];
            }
        }
        GameObject pat2 = (GameObject)Instantiate(pattern2);
        pat2.SetActive(false);
        patPoolObj2.Add(pat2);
        return pat2;
    }

    public GameObject pattern03Spawn()
    {
        for (int i = 0; i < patPoolObj3.Count; i++)
        {
            if (!patPoolObj3[i].activeInHierarchy)
            {
                return patPoolObj3[i];
            }
        }
        GameObject pat3 = (GameObject)Instantiate(pattern3);
        pat3.SetActive(false);
        patPoolObj3.Add(pat3);
        return pat3;
    }
    public GameObject pattern04Spawn()
    {
        for (int i = 0; i < patPoolObj4.Count; i++)
        {
            if (!patPoolObj4[i].activeInHierarchy)
            {
                return patPoolObj4[i];
            }
        }
        GameObject pat4 = (GameObject)Instantiate(pattern4);
        pat4.SetActive(false);
        patPoolObj4.Add(pat4);
        return pat4;
    }
    public GameObject pattern05Spawn()
    {
        for (int i = 0; i < patPoolObj5.Count; i++)
        {
            if (!patPoolObj5[i].activeInHierarchy)
            {
                return patPoolObj5[i];
            }
        }
        GameObject pat5 = (GameObject)Instantiate(pattern5);
        pat5.SetActive(false);
        patPoolObj5.Add(pat5);
        return pat5;
    }
}
