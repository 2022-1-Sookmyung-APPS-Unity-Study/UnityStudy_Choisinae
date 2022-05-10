using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayIntro : MonoBehaviour
{
    bool IsUniform (string[] arr) {

        bool result = true;

        for (int i = 1; i < arr.Length; i++) {

            if(arr[0] != arr[i]) {
                result = false;
            }
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
    
        
    
