using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernisationEquipement : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    public void Action()
    {
        List<Building> building = playerVariables.Buildings;

        foreach (Building buildingData in building)
        {
            buildingData.SuccessRate = (int)(buildingData.SuccessRate * 1.1);
        }
        playerVariables.Money = playerVariables.Money - 300000;
        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 1.1);
        playerVariables.UpdateData();

    }


    void Update()
    {
        
    }
}
