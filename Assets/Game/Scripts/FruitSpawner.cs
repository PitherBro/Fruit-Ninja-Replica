using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

    public GameObject fruitPrefab;
    public Transform[] spawnPoints;

    public float minDelay = .1f;
    public float maxDelay = 1f;

    // Use this for initialization
    void Start() {
        
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits()
    {
        

        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            
            GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            //randomFruitSize(ref spawnedFruit);
            Destroy(spawnedFruit, 10f);
        }
    }
    void randomFruitSize(ref GameObject  sf) {
        float multi = Random.Range(.5f,1.25f);
        sf.transform.localScale = new Vector3(multi,multi,multi);
        gameObject.transform.localScale = new Vector3(multi,multi,multi);
        /*
        Transform half1 = sf.transform.GetChild(0);
        Transform half2 = sf.transform.GetChild(1);
        half1.localScale = new Vector3(multi,multi,multi);
        half2.localScale= new Vector3(multi,multi,multi);
        */
    }
	
}
