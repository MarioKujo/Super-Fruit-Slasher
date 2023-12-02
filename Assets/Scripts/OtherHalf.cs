using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherHalf : MonoBehaviour
{
    [SerializeField]
    Sprite[] sprites;
    [SerializeField]
    Fruit fr;
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[fr.rng];
    }
}
