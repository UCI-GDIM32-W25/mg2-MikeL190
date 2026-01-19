using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject coinSpawner;

    public float minDelay = 1.0f;
    public float maxDelay = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    public void SpawnCoin()
    {
        Instantiate(coinPrefab, coinSpawner.transform.position, Quaternion.identity);
    }

    private IEnumerator SpawnLoop()
    {
        while(true)
        {
            int randomWaitTime = Random.Range(1, 3);
            yield return new WaitForSeconds(randomWaitTime);
            SpawnCoin();
        }
    }

}
