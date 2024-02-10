using UnityEngine;

public class ScoreRemover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Score.score += 3;
    }
}
