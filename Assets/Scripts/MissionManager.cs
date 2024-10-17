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
                
            }
        }

        if (missionCompleted[0]) 
        {
            Mcompletada.SetActive(true);
            missionTexts[0].text = ""; // Limpia si hay menos misiones
            StartCoroutine(HideMision());
        }
        else if (missionCompleted[1])
        {
            Mcompletada.SetActive(true);
            missionTexts[1].text = ""; // Limpia si hay menos misiones
            StartCoroutine(HideMision());
        }
        else if (missionCompleted[2])
        {
            Mcompletada.SetActive(true);
            missionTexts[2].text = ""; // Limpia si hay menos misiones
            StartCoroutine(HideMision());
        }
        else if (missionCompleted[3])
        {
            Mcompletada.SetActive(true);
            missionTexts[3].text = ""; // Limpia si hay menos misiones
            StartCoroutine(HideMision());
        }

        //Mcompletada.SetActive(true);
        //missionTexts[0].text = ""; // Limpia si hay menos misiones
        
    }


    IEnumerator HideMision()
    {
        yield return new WaitForSeconds(3);
        Mcompletada.SetActive(false);

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
