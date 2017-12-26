using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Destroyの前");
            gameObject.SetActive(false);
            Debug.Log("Destroyの後");
        }
    }
}
