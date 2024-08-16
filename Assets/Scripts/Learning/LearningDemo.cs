
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LearningDemo : MonoBehaviour

{
    //bool testBoolean = false;
    //int testInteger = -3;
    float testFloat = 0.5f;
    //string testString = "Oomb";

    // Start is called before the first frame update
    void Start()
    {
        float x = FindSinValue(testFloat);
        
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float FindSinValue(float _incomingAngle)
    { 
        float result;

        result = Mathf.Sin(_incomingAngle);
        
        return result;
    
    }
}
