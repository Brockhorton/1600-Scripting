using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour 
{
    public int Brock = 5;
    private int Sam = 0;
    private int Eli = 5;
    
    private AnotherClass Class;
    
    void Start ()
    {
        Brock = 10;
        
        Class = new AnotherClass();
        Class.Class(Brock, Class.Pans);
    }
    
    void Example (int Gum, int Ball)
    {
        int answer;
        answer = Gum * Ball * Brock;
        Debug.Log(answer);
    }
    
    void Update ()
    {
        Debug.Log("Brock is set to: " + Brock);
    }
}
