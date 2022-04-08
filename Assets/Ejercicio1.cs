using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1==num2)
        {
            Debug.Log("Son iguales");
        }
        else
        {
            Debug.Log("No son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
