using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OptiChauffage : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;


    void Start()
    {
        int heatingFee = playerVariables.GlobalEnergyCost;
        int studentAppreciation = playerVariables.GlobalSatisfactionRate;
        playerVariables.GlobalEnergyCost = (int)(heatingFee * 0.5);
        playerVariables.GlobalSatisfactionRate = (int)(studentAppreciation * 0.9);
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 0.85);
    }

    void Update()
    {
        
    }
}
