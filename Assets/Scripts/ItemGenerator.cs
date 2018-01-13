using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
	private const float ITEM_POSITION_Y = 0.5f;
	
	[SerializeField]
	private int DefaultItems;
	
	private int _currentItems;
	private Vector3 _intPos;

	public bool Ready = false;
	public GameObject ItemPrefab;
	public List<GameObject> ItemList = new List<GameObject>();

	// Use this for initialization
	void Start ()
	{
		_currentItems = DefaultItems;
		
		for(int i=0;i<DefaultItems;i++)
		{
			GenerateItem();
		}
		Debug.Log("after_GenerateItem10");
		Ready = true;
		Debug.Log("Ready = true");
	}
	
	// 何がやりたいのここ？ItemManagerはItemにアタッチされてないし、、、ItemをInstantiateして、ItemManagerの0番に何か入ってるの？？
	void GenerateItem()
	{
		_intPos = new Vector3(Random.Range(-9.0f, 9.0f),ITEM_POSITION_Y, Random.Range(-9.0f, 9.0f));
		GameObject item = Instantiate(ItemPrefab);
		ItemList.Add(item);
		item.transform.parent = gameObject.transform;
		item.transform.position = _intPos;
		item.transform.Rotate(transform.up, Random.Range(0,360));
		
	}

	// Itemが壊れたときに、GameManager経由で呼ばれるもの。
	public void ReActivateItem(GameObject item)
	{
		item.transform.position = new Vector3(Random.Range(-9.0f, 9.0f),ITEM_POSITION_Y, Random.Range(-9.0f, 9.0f));
		item.transform.Rotate(transform.up, Random.Range(0,360));
		item.SetActive(true);
	}
	
}
