using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;

    void Awake ()
    {
        score = 50;
    }
		
    void Update ()
    {
        scoreText.text = score.ToString ();
    }
}
