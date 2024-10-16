using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTriggerUno : MonoBehaviour
{
    public MissionManager missionManager; // Referencia al MissionManager

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el jugador tenga la etiqueta "Player"
        {
            missionManager.CompleteMission(0); // Completa la misión 1 al entrar en el trigger
        }
    }
}
