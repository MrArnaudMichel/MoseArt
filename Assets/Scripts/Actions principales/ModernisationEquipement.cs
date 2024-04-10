using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernisationEquipement : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;

    void Start()
    {
        playerVariables.Money = playerVariables.Money - 300000;
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 1.1);
        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 1.1);
    }

    void Update()
    {
        
    }
}
