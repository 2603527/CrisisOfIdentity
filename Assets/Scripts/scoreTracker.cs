using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoretracker : MonoBehaviour
{
    int score = 0;
    public flag_logic flag;

    public TMP_Text scoredisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    public void add_score()
    {
        score += 10;
        scoredisplay.text = score.ToString();
    }
}
