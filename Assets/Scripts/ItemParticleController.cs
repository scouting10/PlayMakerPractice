using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemParticleController : MonoBehaviour {

	public GameObject _itemBirth;
	public GameObject _itemBreak;
	
	void Awake()
	{
		_itemBirth = transform.GetChild(1).gameObject;
		_itemBreak = transform.GetChild(2).gameObject;
		ResetAllParticles();
	}

	// 現状、ItemDestroyから呼ばれる。そのうちトラブりそう
	public void ResetAllParticles()
	{
		_itemBirth.SetActive(false);
		_itemBreak.SetActive(false);
	}

	// ItemGenerator.GenerateItemより
	public void Play_ItemBirthParticle()
	{
		_itemBirth.gameObject.SetActive(true);
	}

	// ItemDestroyより
	public void Play_ItemBreakParticle()
	{
		_itemBreak.gameObject.SetActive(true);
	}
}
