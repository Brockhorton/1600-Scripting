using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour 
{
    int Bats = 6;
    
    void Start ()
    {
        for(int i = 0; i < Bats; i++)
        {
            Debug.Log ("Creating Bats: " + i);
        }
    }
}
