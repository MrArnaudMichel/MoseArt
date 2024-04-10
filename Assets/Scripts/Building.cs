using System.IO;
using UnityEditor;
using UnityEngine;
using System.Text.Json;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
internal class Building
{
    private readonly string _name;
    private readonly string _description;
    private int _studentNumber;
    private int _studentCapacity;
    private int _studentInWorkStudy;
    private int _studentAppreciation;
    private int _teacherNumber;
    private int _teacherAppreciation;
    private int _successRate;
    private int _age;
    private int _buildingCostToBuild;
    private int _buildingCostToUpgrade;
    private bool _isBuilt;
    private bool _isUpgraded;
    
    public Building(string name)
    {
        foreach (var buildingData in buildingDatas)
        {
            if (buildingData.Name == name)
            {
                _name = buildingData.Name;
                _description = buildingData.Description;
                _studentNumber = buildingData.StudentNumber;
                _studentCapacity = buildingData.StudentCapacity;
                _studentInWorkStudy = buildingData.StudentInWorkStudy;
                _teacherNumber = buildingData.TeacherNumber;
                _successRate = buildingData.SuccessRate;
                _age = buildingData.Age;
                _buildingCostToBuild = buildingData.BuildingCostToBuild;
                _buildingCostToUpgrade = buildingData.BuildingCostToUpgrade;
                _isBuilt = _buildingCostToBuild == 0;
                _isUpgraded = _buildingCostToUpgrade == 0;
            }
        }
    }

    public string Name => _name;
    public string Description => _description;
    public int StudentNumber
    {
        get => _studentNumber;
        set => _studentNumber = value;
    }
    public int StudentCapacity
    {
        get => _studentCapacity;
        set => _studentCapacity = value;
    }
    public int StudentInWorkStudy
    {
        get => _studentInWorkStudy;
        set => _studentInWorkStudy = value;
    }
    public int StudentAppreciation
    {
        get => _studentAppreciation;
        set => _studentAppreciation = value;
    }
    public int TeacherNumber
    {
        get => _teacherNumber;
        set => _teacherNumber = value;
    }
    public int TeacherAppreciation
    {
        get => _teacherAppreciation;
        set => _teacherAppreciation = value;
    }
    public int SuccessRate
    {
        get => _successRate;
        set => _successRate = value;
    }
    public int Age
    {
        get => _age;
        set => _age = value;
    }
    public int BuildingCostToBuild
    {
        get => _buildingCostToBuild;
        set => _buildingCostToBuild = value;
    }
    public int BuildingCostToUpgrade
    {
        get => _buildingCostToUpgrade;
        set => _buildingCostToUpgrade = value;
    }
    public bool IsBuilt
    {
        get => _isBuilt;
        set => _isBuilt = value;
    }
    public bool IsUpgraded
    {
        get => _isUpgraded;
        set => _isUpgraded = value;
    }


    override public string ToString()
    {
        return $"Building: name: {_name}\n" +
               $"description: {_description}\n" +
               $"studentNumber: {_studentNumber}\n" +
               $"studentCapacity: {_studentCapacity}\n" +
               $"studentInWorkStudy: {_studentInWorkStudy}\n" +
               $"teacherNumber: {_teacherNumber}\n" +
               $"successRate: {_successRate}\n" +
               $"age: {_age}\n" +
               $"buildingCostToBuild: {_buildingCostToBuild}\n" +
               $"buildingCostToUpgrade: {_buildingCostToUpgrade}\n" +
               $"isBuilt: {_isBuilt}\n" +
               $"isUpgraded: {_isUpgraded}\n";
    }



    public List<BuildingData> buildingDatas = new List<BuildingData>()
    {
        new BuildingData
        {
            Name = "Informatique",
            Description = "Batiment Informatique",
            StudentNumber = 205,
            StudentCapacity = 210,
            StudentInWorkStudy = 48,
            TeacherNumber = 35,
            SuccessRate = 60,
            Age = 60,
            BuildingCostToBuild = 0,
            BuildingCostToUpgrade = 3000000
        },
        new BuildingData
        {
            Name = "Génie Civil",
            Description = "Batiment Génie Civil",
            StudentNumber = 378,
            StudentCapacity = 500,
            StudentInWorkStudy = 124,
            TeacherNumber = 45,
            SuccessRate = 70,
            Age = 2,
            BuildingCostToBuild = 0,
            BuildingCostToUpgrade = 0,
        },
        new BuildingData
        {
            Name = "Technique de Commercialisation",
            Description = "Batiment Technique de Commercialisation",
            StudentNumber = 259,
            StudentCapacity = 260,
            StudentInWorkStudy = 52,
            TeacherNumber = 25,
            SuccessRate = 75,
            Age = 60,
            BuildingCostToBuild = 0,
            BuildingCostToUpgrade = 5000000,
        },
        new BuildingData
        {
            Name = "Information et Communication",
            Description = "Batiment Information et Communication",
            StudentNumber = 254,
            StudentCapacity = 260,
            StudentInWorkStudy = 78,
            TeacherNumber = 30,
            SuccessRate = 80,
            Age = 60,
            BuildingCostToBuild = 0,
            BuildingCostToUpgrade = 2000000,
            },
        new BuildingData
        {
            Name = "Chimie",
            Description = "Batiment Chimie",
            StudentNumber = 247,
            StudentCapacity = 250,
            StudentInWorkStudy = 64,
            TeacherNumber = 30,
            SuccessRate = 75,
            Age = 60,
            BuildingCostToBuild = 0,
            BuildingCostToUpgrade = 2000000,
        },
    };
}

public class BuildingData
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int StudentNumber { get; set; }
    public int StudentCapacity { get; set; }
    public int StudentInWorkStudy { get; set; }
    public int TeacherNumber { get; set; }
    public int SuccessRate { get; set; }
    public int Age { get; set; }
    public int BuildingCostToBuild { get; set; }
    public int BuildingCostToUpgrade { get; set; }
}
