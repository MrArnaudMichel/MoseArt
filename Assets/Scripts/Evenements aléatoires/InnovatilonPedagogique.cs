using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnovatilonPedagogique
{
    public static void Start(PlayerVariables playerVariables)
    {
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 1.2);
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 1.1);
    }

    void Update()
    {
        
    }
}
