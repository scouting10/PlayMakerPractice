using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    private ItemParticleController _itemParticleController;
    
    void Awake()
    {
        _itemParticleController = GetComponentInParent<ItemParticleController>();
    }
    
    void Start()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            _itemParticleController.ResetAllParticles();
            ItemManager._instance.CheckItemBodyStat();
            ItemManager._instance.AddScore();
            gameObject.SetActive(false);
            _itemParticleController.Play_ItemBreakParticle();
            Debug.Log("ItemDestroyでPlay_Particleよばれた");
        }
    }
}
