using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
 public GameObject GameOverPanel;


public void MostrarGameOver()
{
    GameOverPanel.SetActive(true);
}

    public void Reiniciar()
    {
        Debug.Log("Reiniciando escena...");  // Verifica si este mensaje aparece en la consola
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
