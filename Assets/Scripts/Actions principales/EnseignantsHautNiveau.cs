using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnseignantsHautNiveau : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;

    void Start()
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 1.05);
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 1.1);
        playerVariables.Money = (int)(playerVariables.Money - 0.9);
    }

    void Update()
    {
        
    }
}
