using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField]
    float timer;
    Player1 p1;
    Player2 p2;
    [HideInInspector]
    public SpriteRenderer sr;
    GameController gc;
    [HideInInspector]
    public Animator mechanim;
    [HideInInspector]
    public int rng;
    public static bool sliced = false;
    public static bool isFruit;
    void Start()
    {
        p1 = FindObjectOfType<Player1>();
        p2 = FindObjectOfType<Player2>();
        rng = Random.Range(0, 10);
        gc = FindObjectOfType<GameController>();
        mechanim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (rng > 5)
        {
            isFruit = false;
        }
        else
        {
            isFruit = true;
        }
        if (sliced || !isFruit)
        {
            StartCoroutine(Destruir(timer));
        }
    }
    IEnumerator Destruir(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        Destroy(gameObject);
        gc.spawnedFruit = false;
        sliced = false;
        p1.mechanim.SetBool("Hit", false);
        p2.mechanim.SetBool("Hit", false);
    }
}
