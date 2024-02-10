using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coin;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 offset = new Vector3(Random.Range(-1f, 1f), 0, 0);
            Instantiate(coin, transform.position + offset, transform.rotation);
            Score.score--;
        }
    }
}
