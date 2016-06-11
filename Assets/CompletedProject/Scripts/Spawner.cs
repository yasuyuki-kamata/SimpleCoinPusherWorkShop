using UnityEngine;
using System.Collections;

namespace CompletedProject
{
	public class Spawner : MonoBehaviour
	{
		public GameObject coinPrefab;

		void Update () {
			if (Input.GetButtonDown ("Fire1")) {
				Vector3 offset = new Vector3 (Mathf.Sin(Time.time * 8), 0, 0);
				Instantiate (coinPrefab, transform.position + offset, transform.rotation);
				Score.score--;
			}
		}
	}
}