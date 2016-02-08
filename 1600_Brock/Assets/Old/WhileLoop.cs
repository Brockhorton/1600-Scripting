using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{
    int Paperplanes = 4;
    
    void Start ()
    {
        while(Paperplanes > 0)
        {
            Debug.Log ("I've Made a Plane!");
            Paperplanes--;
        }
    }
}