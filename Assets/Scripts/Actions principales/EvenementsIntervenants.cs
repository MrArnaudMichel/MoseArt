using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evenements : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    public void Action()
    {
        List<Building> building = playerVariables.Buildings;

        foreach (Building buildingData in building)
        {
            buildingData.SuccessRate = (int)(buildingData.SuccessRate * 1.1);
        }
        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 1.1);
        playerVariables.Money = playerVariables.Money - 50000;
        playerVariables.UpdateData();

    }

    void Update()
    {
        
    }
}
