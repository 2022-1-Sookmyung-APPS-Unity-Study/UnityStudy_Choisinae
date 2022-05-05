using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions02 : MonoBehaviour
{
    int Factorial(int number) {
        int result = 1;

        for (int i=1; i <= number; i++) {
            result*= i;
        }

        return result;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
