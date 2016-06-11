using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace CompletedProject
{
	public class Score : MonoBehaviour
	{
		public static int score;
		public Text scoreText;

		void Awake ()
		{
			score = 50;
		}
		
		void Update ()
		{
			scoreText.text = score.ToString ();
		}
	}
}