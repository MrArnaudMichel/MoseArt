using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleveTable : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    void Start()
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 0.98);
        playerVariables.Money = playerVariables.Money - 10000;
    }

    void Update()
    {
        
    }
}
