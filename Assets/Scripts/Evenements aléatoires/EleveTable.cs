using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleveTable
{
    public static void Start(PlayerVariables playerVariables)
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 0.98);
        playerVariables.Money = playerVariables.Money - 10000;
    }

    void Update()
    {
        
    }
}
