using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{
    
    public float paddleSpeed = 10f;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate (paddleSpeed * Time.delta * Input.Getaxis("Horizontal"), 0, 0)
    }
}
