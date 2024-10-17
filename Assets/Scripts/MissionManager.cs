using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    public Text[] missionTexts; // Array para las misiones
    private string[] missions = {
        "Entra en la mansion",
        "Llega al segundo piso de la mansion",
        "Recolectar un objeto de cordura",
        "visita el invernadero"
    };

    public GameObject Mcompletada;

    private bool[] missionCompleted; // Estado de las misiones


    void Start()
    {
        missionCompleted = new bool[missions.Length];
        DisplayMissions();
        Mcompletada.SetActive(false);
    }

    void DisplayMissions()
    {
        for (int i = 0; i < missionTexts.Length; i++)
        {
            if (i < missions.Length)
            {
                missionTexts[i].text = missions[i];
            }
            else
            {
                missionTexts[i].text = ""; // Limpia si hay menos misiones
                Mcompletada.SetActive(true);
            }
        }
    }

    public void CompleteMission(int missionIndex)
    {
        if (missionIndex >= 0 && missionIndex < missionCompleted.Length)
        {
            missionCompleted[missionIndex] = true;
            DisplayMissions();
        }
    }
}
