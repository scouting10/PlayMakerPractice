using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
	public bool IsLookingOff;
	public bool IsFollowing;
	public GameObject ObjTarget;
	public Vector3 Offset;
	

	void Start()
	{
		IsLookingOff = false;
		IsFollowing = true;
		FollowBall();
	}

	void LateUpdate(){

		if (IsLookingOff)
		{
			LookOffBall();
		}
		else if(IsFollowing)
		{
			FollowBall();
		}
	} 

	void FollowBall()
	{
		transform.position = ObjTarget.transform.position + Offset;
		transform.LookAt(ObjTarget.transform.position);
	}

	void LookOffBall()
	{
		transform.LookAt(ObjTarget.transform.position);
	}
}
