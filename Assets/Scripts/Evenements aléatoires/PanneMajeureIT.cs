using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanneMajeureIT : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    void Start()
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 0.9);
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate* 0.95);
        playerVariables.Money = playerVariables.Money - 200000;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
