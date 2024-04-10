using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evenements : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    void Start()
    {
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 1.1);
        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 1.1);
        playerVariables.Money = playerVariables.Money - 50000;
    }

    void Update()
    {
        
    }
}
