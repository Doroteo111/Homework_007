using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_4 : MonoBehaviour
{
    //With a coroutine and a for loop, make a Game Object change its position a finite number of times every 2 seconds.

    private float randomZ = 1f; //-6
    private float randomX = 7f; //-7
    private float randomY = 5f; //-3

    public GameObject cubo;

    private void Start()
    {
        randomX = Random.Range(7, -3);
        randomZ = Random.Range(1, -6);
        randomY = Random.Range(5, -3);

        Vector3 position = new Vector3(randomX, randomY, randomZ);

        GameObject GO = Instantiate(cubo, position, Quaternion.identity);
    }

    /*for (int i = 0; i <= 10; i++)
        {
            randomX = Random.Range(6, -6);
        randomZ = Random.Range(6, -6);
        randomY = Random.Range(1, -1);

        Vector3 position = new Vector3(randomX, randomY, randomZ);

        GameObject GO =Instantiate(cubo, position, Quaternion.identity);

            GO.transform.localScale = Vector3.one * Random.Range(1,3); */


}
