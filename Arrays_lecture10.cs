using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
   
    public int[] myArray = new int[5];
    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log("value : " + myArray[i]);
        }

    }
    void Update()
    {

    }
}
