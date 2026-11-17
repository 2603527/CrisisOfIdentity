using UnityEngine;

public class soundPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource lose_player;
    public AudioSource win_player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spike")
        {
            lose_player.Play();
        };
        if (collision.tag == "Finish")
        {
            win_player.Play();
        }
        ;
    }
}
