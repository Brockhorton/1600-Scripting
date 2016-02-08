using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour 
{
    public int Brock = 5;
    private int Sam = 0;
    private int Eli = 5;
    
    private AnotherClass myOtherClass;
    
    void Start ()
    {
        Brock = 10;
        
        myOtherClass = new AnotherClass();
        myOtherClass.Class(Brock, myOtherClass.Pans);
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
