using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EXERCISE_3 : MonoBehaviour
{
    //: Create a variable named value. Display the content of this variable in a Game Object TextMeshPro.
    //Each time you click the up arrow, you must add 1 to value and display the updated result.
    //Each time you click the down arrow, you must subtract 1 from value and display the updated result.

    
    public TextMeshProUGUI text;
    public int value = 0;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            text.text = $"{value}";
           value++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            text.text = $"{value}";
           value--;
        }

    }

    
}
