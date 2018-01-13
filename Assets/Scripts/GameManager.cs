using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	static public GameManager _instance;
	
	public CameraPosition CameraPos;
	public PlayerPosition PlayerPos;
	public ItemGenerator ItemGenerator;
	public ItemManager ItemManager;
	
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

	public void CheckItemStat()
	{
		for(int i = 0;i < ItemGenerator.ItemList.Count;i++)
		{
			if(!ItemGenerator.ItemList[i].gameObject.activeSelf)
			{
				ItemGenerator.ReActivateItem(ItemGenerator.ItemList[i].gameObject);
			}
		}
	}	
}
