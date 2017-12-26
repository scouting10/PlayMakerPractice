using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
	private const float ITEM_Y = 0.5f;
	
	public GameObject ItemPrefab;
	public int DefaultItemNumber;
	public ItemManager[] ItemManagers;

	private int _currentSet;
	private Vector3 _intPos;

	// Use this for initialization
	void Start ()
	{
		_currentSet = DefaultItemNumber;

		for(int i=0;i<DefaultItemNumber;i++)
		{
			GenerateItem(i);
		}
	}
	
	void GenerateItem(int i)
	{
		_intPos = new Vector3(Random.Range(-9.0f, 9.0f),ITEM_Y, Random.Range(-9.0f, 9.0f));
		GameObject item = Instantiate(ItemPrefab);
		ItemManagers[i].Instance = item;
		item.transform.parent = gameObject.transform;
		item.transform.position = _intPos;
		item.transform.Rotate(transform.up, Random.Range(0,360));
		
	}

	// Itemが壊れたときに、GameManager経由で呼ばれるもの。
	public void ReActivateItem(GameObject item)
	{
		item.transform.position = new Vector3(Random.Range(-9.0f, 9.0f),ITEM_Y, Random.Range(-9.0f, 9.0f));
		item.transform.Rotate(transform.up, Random.Range(0,360));
		item.SetActive(true);
	}
	
}
