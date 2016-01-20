using UnityEngine;
using System.Collections;

public class At : MonoBehaviour 
{
	public int myInt = 0;
	// Use this for initialization
	void Start () 
	{

	}
	// Update is called once per frame
	void Update () 
	{
		myInt = AddOne (myInt);
		Debug.Log (myInt);
	}
		int AddOne (int Number)
	{
		int ret;
		ret = Number + 2;
		return ret;
	}
}