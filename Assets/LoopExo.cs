using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 100; i+=1) {
            if (i % 5==0 && i % 3==0)
            {
                print(i);
            }
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
