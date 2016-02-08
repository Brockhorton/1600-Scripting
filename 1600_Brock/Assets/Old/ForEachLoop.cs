using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour 
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "First Mouse";
        strings[1] = "Second Mouse";
        strings[2] = "Third Mouse";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}