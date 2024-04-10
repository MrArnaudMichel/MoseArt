using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class RenovationEnergetique : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    [SerializeField] Building building;
    void Start()
    {
        building.EnergyCost = building.EnergyCost / 2;
        building.StudentAppreciation = (int)(building.StudentAppreciation * 1.1);
        playerVariables.Money = playerVariables.Money - 1000000;

    }

    void Update()
    {
        
    }
}
