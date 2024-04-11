using UnityEngine;

public class Bilan : MonoBehaviour
{
    [SerializeField] private PlayerVariables playerVariables;

    void Start()
    {
        playerVariables = GetComponent<PlayerVariables>();
        CompareAndDisplaySummary();
    }

    void CompareAndDisplaySummary()
    {
        int savedMoney = PlayerPrefs.GetInt("money", 0);
        int savedGlobalSatisfactionRate = PlayerPrefs.GetInt("globalSatisfactionRate", 0);
        int savedSuccessRate = PlayerPrefs.GetInt("success_rate", 0);
        int savedGlobalNumberOfStudents = PlayerPrefs.GetInt("globalNumberOfStudents", 0);
        int savedGlobalNumberStudentCapacity = PlayerPrefs.GetInt("globalNumberStudentCapacity", 0);
        int savedGlobalNumberOfStudentsInWorkStudy = PlayerPrefs.GetInt("globalNumberOfStudentsInWorkStudy", 0);
        int savedGlobalNumberOfTeachers = PlayerPrefs.GetInt("globalNumberOfTeachers", 0);
        int savedGlobalNumberSalaryOfTeachers = PlayerPrefs.GetInt("globalNumberSalaryOfTeachers", 0);
        int savedGlobalNumberOfBuildings = PlayerPrefs.GetInt("globalNumberOfBuildings", 0);
        int savedGlobalEnergyCost = PlayerPrefs.GetInt("globalEnergyCost", 0);
        int savedAttractionRate = PlayerPrefs.GetInt("attractionRate", 0);
        int savedQuotaGeneralTechnological = PlayerPrefs.GetInt("quotaGeneralTechnological", 0);
        int savedErasmus = PlayerPrefs.GetInt("erasmus", 0);

        Debug.Log("Résumé des différences :");
        Debug.Log("Argent : " + (playerVariables.Money - savedMoney));
        Debug.Log("Taux de satisfaction global : " + (playerVariables.GlobalSatisfactionRate - savedGlobalSatisfactionRate));
        Debug.Log("Taux de réussite : " + (playerVariables.SuccessRate - savedSuccessRate));
        Debug.Log("Nombre d'étudiants global : " + (playerVariables.GlobalNumberOfStudents - savedGlobalNumberOfStudents));
        Debug.Log("Capacité d'étudiants global : " + (playerVariables.GlobalNumberStudentCapacity - savedGlobalNumberStudentCapacity));
        Debug.Log("Nombre d'étudiants en alternance global : " + (playerVariables.GlobalNumberOfStudentsInWorkStudy - savedGlobalNumberOfStudentsInWorkStudy));
        Debug.Log("Nombre de professeurs global : " + (playerVariables.GlobalNumberOfTeachers - savedGlobalNumberOfTeachers));
        Debug.Log("Salaire des professeurs global : " + (playerVariables.GlobalNumberSalaryOfTeachers - savedGlobalNumberSalaryOfTeachers));
        Debug.Log("Nombre de bâtiments global : " + (playerVariables.GlobalNumberOfBuildings - savedGlobalNumberOfBuildings));
        Debug.Log("Coût énergétique global : " + (playerVariables.GlobalEnergyCost - savedGlobalEnergyCost));
        Debug.Log("Taux d'attraction : " + (playerVariables.AttractionRate - savedAttractionRate));
        Debug.Log("Quota technologique général : " + (playerVariables.QuotaGeneralTechnological - savedQuotaGeneralTechnological));
        Debug.Log("Erasmus : " + (playerVariables.Erasmus - savedErasmus));
    }
}
