using UnityEngine;
using System.Collections;

public class DatatypeScript : MonoBehaviour 
{
	void Start () 
    {
        Vector3 pos = transform.position;
        pos = new Vector3(10, 4, 10);
        
        Transform tran = transform;
        tran.position = new Vector3(10, 4, 10);
    }
}
