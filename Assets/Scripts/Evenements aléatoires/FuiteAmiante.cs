using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuiteAmiante : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    void Start()
    {
        playerVariables.Money = playerVariables.Money - 1000000;
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 0.85);
    }

    void Update()
    {
        
    }
}
