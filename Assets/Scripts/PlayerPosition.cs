using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
	const int DEADLINE = -13;
	public bool IsDeadLine;
	public bool IsStartPosition;
	private Rigidbody _rb;

	// Use this for initialization
	void Start ()
	{
		IsDeadLine = false;
		IsStartPosition = false;
		_rb = GetComponent<Rigidbody>();

	}
	void Update () {
		if (transform.position.y < DEADLINE)
		{
			ResetBallPoition();
		}
	}

	void ResetBallPoition()
	{
		IsStartPosition = true;
		IsDeadLine = false;
		transform.position = new Vector3(0, 2, 0);
		_rb.velocity = new Vector3(0,0,0);
		_rb.ResetInertiaTensor();
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "DeadLine")
		{
			IsStartPosition = false;
			IsDeadLine = true;
		}
	}
}
