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

    public void CheckItemBodyStat()
	{
        Debug.Log("CheckItemStat呼ばれた");
		for(int i = 0;i < ItemGenerator.ItemList.Count;i++)
		{
            Debug.Log("forに入った。iの値　＝"+i);
			if(!ItemGenerator.ItemList[i].transform.GetChild(0).gameObject.activeSelf)
			{
                Debug.Log("ifに入った");
				ItemGenerator.ReActivateItem(ItemGenerator.ItemList[i].gameObject);
			}
		}
	}

    public void AddScore()
    {
        GameManager._instance.CountScore(100);
    }

}
