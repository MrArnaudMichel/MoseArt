using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveActualPlayerVariable : MonoBehaviour
{
    [SerializeField] private PlayerVariables playerVariables;
    public void SaveActualPlayerVariables()
    {
        PlayerPrefs.SetInt("money", playerVariables.Money);
        PlayerPrefs.SetInt("globalSatisfactionRate", playerVariables.GlobalSatisfactionRate);
        PlayerPrefs.SetInt("success_rate", playerVariables.SuccessRate);
        PlayerPrefs.SetInt("globalNumberOfStudents", playerVariables.GlobalNumberOfStudents);
        PlayerPrefs.SetInt("globalNumberStudentCapacity", playerVariables.GlobalNumberStudentCapacity);
        PlayerPrefs.SetInt("globalNumberOfStudentsInWorkStudy", playerVariables.GlobalNumberOfStudentsInWorkStudy);
        PlayerPrefs.SetInt("globalNumberOfTeachers", playerVariables.GlobalNumberOfTeachers);
        PlayerPrefs.SetInt("globalNumberSalaryOfTeachers", playerVariables.GlobalNumberSalaryOfTeachers);
        PlayerPrefs.SetInt("globalNumberOfBuildings", playerVariables.GlobalNumberOfBuildings);
        PlayerPrefs.SetInt("globalEnergyCost", playerVariables.GlobalEnergyCost);
        PlayerPrefs.SetInt("attractionRate", playerVariables.AttractionRate);
        PlayerPrefs.SetInt("quotaGeneralTechnological", playerVariables.QuotaGeneralTechnological);
        PlayerPrefs.SetInt("erasmus", playerVariables.Erasmus);
    }
    void Start()
    {
        playerVariables = GetComponent<PlayerVariables>();
        SaveActualPlayerVariables();
        
    }

    void Update()
    {
        
    }
}
