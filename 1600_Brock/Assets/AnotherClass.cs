using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour 
{
 public int Cans;
    public int Pans;
    private int Hats;
    private int Bats;
    
    public void Class (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Class total: " + answer);
    }
    
    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("total: " + answer);
    }
}