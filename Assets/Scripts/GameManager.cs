using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public CameraPosition CameraPos;
	public PlayerPosition PlayerPos;
	public ItemGenerator ItemGenerator;
	public ItemManager[] ItemManagers;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		CameraController();
		CheckItemStat();
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

	void CheckItemStat()
	{
		for(int i = 0;i < ItemManagers.Length;i++)
		{
			if(!ItemManagers[i].gameObject.activeSelf)
			{
				ItemGenerator.ReActivateItem(ItemManagers[i].gameObject);
			}
		}
	}
	
}
