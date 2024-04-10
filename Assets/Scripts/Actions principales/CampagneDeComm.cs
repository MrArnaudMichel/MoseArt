using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampagneDeComm : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    [SerializeField] Building building;
    void Start()
    {
        playerVariables.GlobalSatisfactionRate = (int)(playerVariables.GlobalSatisfactionRate * 1.05);
        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 1.05);
        foreach (var buildingData in building.buildingDatas)
        {
            buildingData.StudentNumber = (int)(buildingData.StudentNumber +10);
        }
        playerVariables.Money = playerVariables.Money - 100000;
    }

    void Update()
    {
        
    }
}
