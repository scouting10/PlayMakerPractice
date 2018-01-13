using System;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public ItemGenerator ItemGenerator;

    void Start()
    {
        ItemGenerator.SpawnItems();
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

    public void AddScore()
    {
        //GameManagerに
    }

}
