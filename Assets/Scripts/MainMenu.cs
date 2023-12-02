using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject canvasTitle;
    [SerializeField]
    GameObject canvasSure;
    private void Start()
    {
        canvasTitle.SetActive(true);
        canvasSure.SetActive(false);
    }
    string sceneName;
    public void CargarNivel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);//Carga la escena que se introduzca en unity
    }
    public void Quit()
    {
        canvasTitle.SetActive(false);
        canvasSure.SetActive(true);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Volver()
    {
        canvasSure.SetActive(false);
        canvasTitle.SetActive(true);
    }
}
