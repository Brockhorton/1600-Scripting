using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	int myInt = 2000;
	// Use this for initialization
	void Start () 
	{
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}
	int MultiplyByTwo (int Number)
	{
		int ret;
		ret = Number * 2;
		return ret;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}