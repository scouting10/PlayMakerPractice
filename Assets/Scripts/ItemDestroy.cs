using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Itemの位置:" + transform.position);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ItemManager._instance.CheckItemStat();
            ItemManager._instance.AddScore();
            //_itemBreak.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
