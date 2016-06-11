using UnityEngine;
using System.Collections;

namespace CompletedProject
{
	public class ScoreRemover : MonoBehaviour
	{
		void OnTriggerEnter (Collider col)
		{
			Destroy (col.gameObject);
			Score.score += 3;
		}
	}
}