using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OptiChauffage : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;

    public void Action()
    {
        Debug.Log("OptiChauffage");
        List<Building> building = playerVariables.Buildings;
        foreach (Building buildingInf in building)
        {
            buildingInf.SuccessRate = (int)(buildingInf.SuccessRate * 0.85);
            buildingInf.EnergyCost = (int)(buildingInf.EnergyCost * 0.5);
            buildingInf.StudentAppreciation = (int)(buildingInf.StudentAppreciation * 0.9);
            playerVariables.UpdateData();
        }
    }

    void Update()
    {
        
    }
}
