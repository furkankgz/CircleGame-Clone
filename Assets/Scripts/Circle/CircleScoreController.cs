using UnityEngine;
using TMPro;

public class CircleScoreController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    private int score = 0;

    public void IncreaseScoreValue()
    {
        score++;
        SetScoreText();
    }

    private void SetScoreText()
    {
        scoreText.text = score.ToString();
    }

}
