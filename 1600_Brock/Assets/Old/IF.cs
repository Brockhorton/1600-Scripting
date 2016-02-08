using UnityEngine;
using System.Collections;

public class IF : MonoBehaviour
{
    float Height = 100.0f;
    float ToHighLimit = 70.0f;
    float ToLowLimit = 30.0f;

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            HeightTest();
        
        Height -= Time.deltaTime * 10f;
    }
    
    void HeightTest ()
    {
        if(Height > ToHighLimit)
        {
            print("Too high.");
        }
        else if(Height < ToLowLimit)
        {
            print("Too low.");
        }
        else
        {
            print("Just right.");
        }
    }
}
