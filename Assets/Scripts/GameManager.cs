using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	static public GameManager _instance;
	public int _currentScore;
	public CameraPosition CameraPos;
	public PlayerPosition PlayerPos;
	
	void Awake()
	{
		if(_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	void Update () 
	{
		CameraController();
	}

	void CameraController()
	{
		if (PlayerPos.IsStartPosition)
		{
			CameraPos.IsLookingOff = false;
			CameraPos.IsFollowing = true;
		
		}
			else if(PlayerPos.IsDeadLine)
		{
			CameraPos.IsFollowing = false;
			CameraPos.IsLookingOff = true;
		}
	}

	public void CountScore(int score)
	{
		_currentScore += score;
	}

		
}
