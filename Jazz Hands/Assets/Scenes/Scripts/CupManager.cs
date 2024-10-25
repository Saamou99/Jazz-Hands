using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupManager : MonoBehaviour
{
    public Cup[] cups; // Array to store all the cups in the scene
    public float resetInterval = 60f; // Time after which all cups reset

    void Start()
    {
        StartCoroutine(ResetCupsRoutine());
    }

    IEnumerator ResetCupsRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(resetInterval); // Wait for 1 minute

            // Reset all cups
            foreach (Cup cup in cups)
            {
                cup.ResetCup();
            }
        }
    }
}