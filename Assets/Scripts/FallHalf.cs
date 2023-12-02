using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FallHalf : MonoBehaviour
{
    [SerializeField]
    public Sprite[] sprites;
    [SerializeField]
    Fruit fr;
    SpriteRenderer sr;
    public AudioSource clip;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[fr.rng];
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Fruit.isFruit)
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                GameController.score1++;
            }
            else if (collision.gameObject.CompareTag("Player2"))
            {
                GameController.score2++;
            }
            fr.mechanim.SetTrigger("Slice");
            Fruit.sliced = true;
            clip.Play();
        }
        else
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                int counterp1 = 0;
                if (counterp1 == 0 && GameController.score1 != 0)
                {
                    GameController.score1--;
                }
                collision.gameObject.GetComponentInParent<Animator>().SetBool("Hit", true);
                counterp1++;
            }
            else if (collision.gameObject.CompareTag("Player2"))
            {
                int counterp2 = 0;
                if (counterp2 == 0 && GameController.score2 != 0)
                {
                    GameController.score2--;
                }
                collision.gameObject.GetComponentInParent<Animator>().SetBool("Hit", true);
                counterp2++;
            }
        }
    }
}
