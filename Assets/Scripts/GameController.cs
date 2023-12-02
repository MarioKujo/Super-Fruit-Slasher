using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject canvasWin;
    [SerializeField]
    Text scoreP1;
    public static int score1;
    [SerializeField]
    Text scoreP2;
    [SerializeField]
    Text winText;
    public static int score2;
    [SerializeField]
    GameObject prefabFruta;
    [HideInInspector]
    public bool spawnedFruit = false;
    public AudioSource clip;
    private void Awake()
    {
        canvasWin.SetActive(false);
    }
    private void FixedUpdate()
    {
        if (!spawnedFruit)
        {
            Instantiate(prefabFruta);
            spawnedFruit = true;
        }
        scoreP1.text = "j1: " + score1;
        scoreP2.text = "j2: " + score2;
        if (!Fruit.sliced)
        {
            Win();
        }
    }
    public void Win()
    {
        if (score1 == 10 && score2 == 10)
        {
            canvasWin.SetActive(true);
            Time.timeScale = 0;
            winText.text = "It's a tie!";
            winText.color = Color.gray;
            clip.Play();
        }
        if (score1 == 10 && score2 != 10)
        {
            canvasWin.SetActive(true);
            Time.timeScale = 0;
            winText.text = "Player 1 wins!";
            winText.color = Color.blue;
            clip.Play();
        }
        if (score2 == 10 && score1 != 10)
        {
            canvasWin.SetActive(true);
            Time.timeScale = 0;
            winText.text = "Player 2 wins!";
            winText.color = Color.red;
            clip.Play();
        }
        
    }
}
