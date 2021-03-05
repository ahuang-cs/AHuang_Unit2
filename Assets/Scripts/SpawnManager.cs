using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPosRange = 13f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            float randXPos = Random.Range(-xPosRange, xPosRange);
            int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 randPos = new Vector3(randXPos, 0f, 21f);

            Instantiate(animalPrefabs[animalPrefabIndex], randPos, animalPrefabs[animalPrefabIndex].transform.rotation);
        }
    }
}
