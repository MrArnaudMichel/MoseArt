using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerVariables : MonoBehaviour
{
    [SerializeField] private int money = 2700000;
    [SerializeField] private List<Building> buildings = new List<Building>();
    [SerializeField] private int globalSatisfactionRate = 0;
    [SerializeField] private int success_rate = 0;
    [SerializeField] private int globalNumberOfStudents = 0;
    [SerializeField] private int globalNumberStudentCapacity = 0;
    [SerializeField] private int globalNumberOfStudentsInWorkStudy = 0;
    [SerializeField] private int globalNumberOfTeachers = 0;
    [SerializeField] private int globalNumberSalaryOfTeachers = 0;
    [SerializeField] private int globalNumberOfBuildings = 0;
    [SerializeField] private int globalEnergyCost = 0;
    [SerializeField] private int attractionRate = 50;
    [SerializeField] private int quotaGeneralTechnological = 0;
    [SerializeField] private int erasmus = 0;

    [SerializeField] public int year = 1;
    [SerializeField] public int trimester = 1;

    public void Start()
    {
        addBuildings();
        globalNumberOfStudents = GetGlobalNumberOfStudents();
        globalNumberOfTeachers = GetGlobalNumberOfTeachers();
        globalNumberOfBuildings = GetGlobalNumberOfBuildings();
        globalSatisfactionRate = GetGlobalSatisfactionRate();
        globalNumberOfStudentsInWorkStudy = GetGlobalNumberOfStudentsInWorkStudy();
        globalEnergyCost = GetGlobalEnergyCost();
        globalNumberStudentCapacity = GetGlobalNumberStudentCapacity();
        globalNumberSalaryOfTeachers = GetGlobalNumberSalaryOfTeachers();
        success_rate = GetSuccessRate();
    }

    public int Money { get => money; set => money = value; }
    public List<Building> Buildings { get => buildings; set => buildings = value; }
    public int GlobalSatisfactionRate { get => globalSatisfactionRate; set => globalSatisfactionRate = value; }
    public int SuccessRate { get => success_rate; set => success_rate = value; }
    public int GlobalNumberOfStudents { get => globalNumberOfStudents; set => globalNumberOfStudents = value; }
    public int GlobalNumberStudentCapacity { get => globalNumberStudentCapacity; set => globalNumberStudentCapacity = value; }
    public int GlobalNumberOfStudentsInWorkStudy { get => globalNumberOfStudentsInWorkStudy; set => globalNumberOfStudentsInWorkStudy = value; }
    public int GlobalNumberOfTeachers { get => globalNumberOfTeachers; set => globalNumberOfTeachers = value; }
    public int GlobalNumberSalaryOfTeachers { get => globalNumberSalaryOfTeachers; set => globalNumberSalaryOfTeachers = value; }
    public int GlobalNumberOfBuildings { get => globalNumberOfBuildings; set => globalNumberOfBuildings = value; }
    public int GlobalEnergyCost { get => globalEnergyCost; set => globalEnergyCost = value; }
    public int AttractionRate { get => attractionRate; set => attractionRate = value; }
    public int QuotaGeneralTechnological { get => quotaGeneralTechnological; set => quotaGeneralTechnological = value; }
    public int Erasmus { get => erasmus; set => erasmus = value; }


    private int GetGlobalNumberSalaryOfTeachers()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += building.TeachSalary;
        }
        return total;
    }

    private int GetGlobalNumberStudentCapacity()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += building.StudentCapacity;
        }
        return total;
    }

    private int GetGlobalEnergyCost()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += building.EnergyCost;
        }
        return total;
    }

    private int GetGlobalSatisfactionRate()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += (building.StudentAppreciation + building.TeacherAppreciation) / 2;
        }
        return total / buildings.Count;
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

    private int GetGlobalNumberOfStudentsInWorkStudy()
    {
        int total = 0;
        foreach (Building building in buildings)
        {
            total += building.StudentInWorkStudy;
        }

        return total;
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