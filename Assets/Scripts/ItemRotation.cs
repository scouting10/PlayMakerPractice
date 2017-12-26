using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
	private float _rotSpeed = 80;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(new Vector3(0,1,0), _rotSpeed*Time.deltaTime);
	}
}
