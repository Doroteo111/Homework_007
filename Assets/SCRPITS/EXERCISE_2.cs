using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EXERCISE_2 : MonoBehaviour
{
    //Make a timer with a corroutine. You must display the seconds on the screen with a Game Object TextMeshPro.
    public int counter = 0;
    public TextMeshProUGUI text;

    private void Start()
    {

        StartCoroutine(countDown());
    }

   private IEnumerator countDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            text.text = $"{counter}";
            counter++;
        }
       
    }

}
