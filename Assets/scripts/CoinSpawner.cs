using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coinPrefab;
    
    public float spawnTime = 10f;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(coinPrefab[Random.Range(0,6)], new Vector2(Random.Range(-13f, 13f), 6), transform.rotation);
            timer = spawnTime;

        }
    }
}
