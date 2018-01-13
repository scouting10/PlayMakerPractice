using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ItemManager._instance.CheckItemStat();
            ItemManager._instance.AddScore();
            gameObject.SetActive(false);
        }
    }
}
