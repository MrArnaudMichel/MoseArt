using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NouveauParcours : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;

    void Start()
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 1.05);
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 1.05);

        playerVariables.Money = playerVariables.Money - 200000;
    }

    void Update()
    {
        
    }
}
