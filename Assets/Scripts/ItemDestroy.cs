using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    public ItemManager ItemManager;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Debug.Log("before");
            GameManager._instance.CheckItemStat();
            Debug.Log("after");
        }
    }
}
