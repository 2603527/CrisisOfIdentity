using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreTracker : MonoBehaviour
{
    public TMP_Text scoredisplay;
    private int score;
   public void add_score()
   {
        score += 10;
        scoredisplay.text = "Score: " + score.ToString();
   }
}
