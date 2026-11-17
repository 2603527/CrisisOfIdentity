using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoretracker : MonoBehaviour
{
    int score = 0;
    flag_logic flag;

    public TMP_Text scoredisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flag = GameObject.FindAnyObjectByType<flag_logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag.finished == true)
        {
            score += 10;
            scoredisplay.text = score.ToString();
        }
    }
}
