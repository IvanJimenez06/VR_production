using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTriggerDos : MonoBehaviour
{
    public MissionManager missionManager; // Referencia al MissionManager

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Aseg�rate de que el jugador tenga la etiqueta "Player"
        {
            missionManager.CompleteMission(1); // Completa la misi�n 1 al entrar en el trigger
            gameObject.SetActive(false);
        }
    }
}
