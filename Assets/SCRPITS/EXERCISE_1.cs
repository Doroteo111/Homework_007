using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE_1 : MonoBehaviour
{
    //Instantiate a given number of cubes in random positions with random scales.

    private float randomZ = 6f;
    private float randomX = 6f;
    private float randomY= 1f;

    public GameObject cubo;
    

    
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            randomX = Random.Range(6, -6);
        randomZ = Random.Range(6, -6);
        randomY = Random.Range(1, -1);

        Vector3 position = new Vector3(randomX, randomY, randomZ);

        GameObject GO =Instantiate(cubo, position, Quaternion.identity);

            GO.transform.localScale = Vector3.one * Random.Range(1,3);

        }



    }
   



    
    
      
    
   
}
