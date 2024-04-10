using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobiliteInternationale : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;

    void Start()
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate*1.1);
        playerVariables.SuccessRate = (int)((playerVariables.SuccessRate * 1.05));
        playerVariables.Money = (int)(playerVariables.Money - 100000);
    }

    void Update()
    {
        
    }
}
