using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampagneDeComm : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    public void Action()
    {
        List<Building> building = playerVariables.Buildings;

        playerVariables.AttractionRate = (int)(playerVariables.AttractionRate * 1.05);
        foreach (Building buildingData in building)
        {
            buildingData.StudentAppreciation = (int)(buildingData.StudentAppreciation * 1.05);
            if (buildingData.StudentNumber < buildingData.StudentCapacity)
            {
                buildingData.StudentNumber = (int)(buildingData.StudentNumber + 10);
            }
            else { }
        }
        playerVariables.Money = playerVariables.Money - 100000;
        playerVariables.UpdateData();
    }

    void Update()
    {
        
    }
}
