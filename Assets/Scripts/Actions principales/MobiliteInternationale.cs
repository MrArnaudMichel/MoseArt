using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobiliteInternationale : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    public void Action()
    {
        List<Building> building = playerVariables.Buildings;

        foreach (Building buildingData in building)
        {
            buildingData.SuccessRate = (int)(buildingData.SuccessRate *1.05);
            buildingData.StudentAppreciation = (int)(buildingData.StudentAppreciation * 1.1);
        }
        playerVariables.Money = (int)(playerVariables.Money - 100000);
        playerVariables.UpdateData();

    }

    void Update()
    {
        
    }
}
