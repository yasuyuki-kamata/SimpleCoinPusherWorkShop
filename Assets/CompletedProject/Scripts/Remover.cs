using UnityEngine;
using System.Collections;

namespace CompletedProject
{
	public class Remover : MonoBehaviour
	{
		void OnTriggerEnter (Collider col)
		{
			Destroy (col.gameObject);
		}
	}
}