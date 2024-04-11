using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NouveauParcours : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    public void Action()
    {
        List<Building> building = playerVariables.Buildings;

        foreach (Building buildingData in building)
        {
            buildingData.SuccessRate = (int)(buildingData.SuccessRate * 1.05);
            buildingData.StudentAppreciation = (int)(buildingData.StudentAppreciation * 1.05);
        }
        playerVariables.Money = playerVariables.Money - 200000;
        playerVariables.UpdateData();

    }

    void Update()
    {
        
    }
}
