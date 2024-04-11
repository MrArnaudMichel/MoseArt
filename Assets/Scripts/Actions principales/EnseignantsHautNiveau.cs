using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnseignantsHautNiveau : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    public void Action()
    {
        List<Building> building = playerVariables.Buildings;

        foreach (Building buildingData in building)
        {
            buildingData.SuccessRate = (int)(buildingData.SuccessRate * 1.1);
            buildingData.StudentAppreciation = (int)(buildingData.StudentAppreciation * 1.05);
        }
        playerVariables.Money = (int)(playerVariables.Money * 0.9);
        playerVariables.UpdateData();
    }

    void Update()
    {
        
    }
}
