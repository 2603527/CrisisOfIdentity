using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoretracker : MonoBehaviour
{
    int score = 0;
    public flagLogic flag;

    public TMP_Text scoredisplay;

    public void add_score()
    {
        score += 10;
        scoredisplay.text = score.ToString();
    }
}
