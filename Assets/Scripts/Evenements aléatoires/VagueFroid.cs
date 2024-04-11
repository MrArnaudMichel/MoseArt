using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VagueFroid
{
    public static void Start(PlayerVariables playerVariables)
    {
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 0.95);
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 0.95);
        playerVariables.Money = playerVariables.Money - 50000;
    }

    void Update()
    {
        
    }
}
