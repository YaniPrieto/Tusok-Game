using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePool : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Particles Game Object")]
    [SerializeField] GameObject appleParticle;
    [SerializeField] GameObject rottenParticle;

    [Header("Fields")]
    [SerializeField] int amountToPool;

    [Header("List")]
    List<GameObject> applePartList = new List<GameObject>();
    List<GameObject> rottenPartList = new List<GameObject>();

    public static ParticlePool instance;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            //Part = Particles
            GameObject applePart = (GameObject)Instantiate(appleParticle);
            applePart.SetActive(false);
            applePartList.Add(applePart);

            GameObject rottenPart = (GameObject)Instantiate(rottenParticle);
            rottenPart.SetActive(false);
            rottenPartList.Add(rottenPart);
        }
    }
    public GameObject SpawnAppleParticle()
    {
        for (int i = 0; i < applePartList.Count; i++)
        {
            if (!applePartList[i].activeInHierarchy)
            {
                return applePartList[i];
            }
        }
        GameObject applePart = (GameObject)Instantiate(appleParticle);
        applePart.SetActive(false);
        applePartList.Add(applePart);
        return applePart;
    }
    public GameObject SpawnRottenParticle()
    {
        for (int i = 0; i < rottenPartList.Count; i++)
        {
            if (!rottenPartList[i].activeInHierarchy)
            {
                return rottenPartList[i];
            }
        }
        GameObject rottenPart = (GameObject)Instantiate(rottenParticle);
        rottenPart.SetActive(false);
        rottenPartList.Add(rottenPart);
        return rottenPart;
    }
}
