using System;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    static public ItemManager _instance;

    public ItemGenerator ItemGenerator;

    void Awake()
    {
        _instance = this;
    }
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
