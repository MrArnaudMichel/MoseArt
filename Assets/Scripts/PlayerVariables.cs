using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerVariables : MonoBehaviour
{
    [SerializeField] private int money = 2700000;
    [SerializeField] private List<Building> buildings = new List<Building>();
    [SerializeField] private int satisfaction_rate = 0;
    [SerializeField] private int reputation = 50;
    [SerializeField] private int success_rate = 0;
    [SerializeField] private int globalNumberOfStudents = 0;
    [SerializeField] private int globalNumberOfTeachers = 0;
    [SerializeField] private int globalNumberOfBuildings = 0;


    public void Start()
    {
        addBuildings();
        globalNumberOfStudents = GetGlobalNumberOfStudents();
        globalNumberOfTeachers = GetGlobalNumberOfTeachers();
        globalNumberOfBuildings = GetGlobalNumberOfBuildings();
        satisfaction_rate = GetSatisfactionRate();
        success_rate = GetSuccessRate();
    }

    private int GetSatisfactionRate()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += (building.StudentAppreciation + building.TeacherAppreciation) / 2;
        }
        return total / buildings.Count;
    }

    private int GetSuccessRate()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += building.SuccessRate;
        }
        return total / globalNumberOfBuildings;
    }

    private int GetGlobalNumberOfStudents()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += building.StudentNumber;
        }

        return total;
    }

    private int GetGlobalNumberOfTeachers()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += building.TeacherNumber;
        }

        return total;
    }

    private int GetGlobalNumberOfBuildings()
    {
        return buildings.Count;
    }

    private void addBuildings()
    {
        buildings.Add(new Building("Informatique"));
        buildings.Add(new Building("Génie Civil"));
        buildings.Add(new Building("Technique de Commercialisation"));
        buildings.Add(new Building("Information et Communication"));
        buildings.Add(new Building("Chimie"));
        Debug.Log(buildings[0].ToString());
    }
}