using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Logic : MonoBehaviour
{
    private int coinMovementSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown_Timer());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * coinMovementSpeed * Time.deltaTime;
    }

    private IEnumerator Countdown_Timer()
    {
        yield return new WaitForSeconds(8);
        Destroy(gameObject);
    }

}
