using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pandemie : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    void Start()
    {
        playerVariables.Money = playerVariables.Money - 1000000;
        playerVariables.SuccessRate = (int)(playerVariables.SuccessRate * 0.8);
    }

    void Update()
    {
        
    }
}
