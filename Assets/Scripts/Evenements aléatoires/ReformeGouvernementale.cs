using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReformeGouvernementale
{
    public static void Start(PlayerVariables playerVariables)
    {
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 0.8);
        playerVariables.Money = playerVariables.Money - 100000;
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 0.8);
        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 1.3);
    }

    void Update()
    {
        
    }
}
