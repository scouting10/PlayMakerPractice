using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
	private const float ITEM_POSITION_Y = 0.5f;
	
	static public ItemGenerator _instance;

	[SerializeField]
	private int DefaultItems;
	
	private int _currentItems;
	private Vector3 _intPos;

	public GameObject ItemPrefab;
	public List<GameObject> ItemList = new List<GameObject>();

	void Awake()
	{
		_instance = this;
	}
	
	public void SpawnItems()
	{
		_currentItems = DefaultItems;
		
		for(int i=0;i<DefaultItems;i++)
		{
			GenerateItem();
		}
	}
	
	void GenerateItem()
	{
		_intPos = new Vector3(Random.Range(-9.0f, 9.0f),ITEM_POSITION_Y, Random.Range(-9.0f, 9.0f));
		GameObject item = Instantiate(ItemPrefab);
		ItemList.Add(item);
		item.transform.position = _intPos;
		item.transform.Rotate(transform.up, Random.Range(0,360));
		
	}

	// Itemが壊れたときに、ItemManager経由でItemDestroyから呼ばれる。
	public void ReActivateItem(GameObject item)
	{
		item.transform.position = new Vector3(Random.Range(-9.0f, 9.0f),ITEM_POSITION_Y, Random.Range(-9.0f, 9.0f));
		item.transform.Rotate(transform.up, Random.Range(0,360));
		item.SetActive(true);
	}
	
}
