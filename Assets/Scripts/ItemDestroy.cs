using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    public ItemManager ItemManager;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ItemManager.CheckItemStat();
            ItemManager.AddScore();
            //gameObject.SetActive(false);
            Debug.Log("destroy");
        }
    }
}
