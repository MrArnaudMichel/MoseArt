using UnityEngine;

public class Bilan : MonoBehaviour
{
    [SerializeField] private PlayerVariables playerVariables;

    void Start()
    {
        playerVariables = GetComponent<PlayerVariables>();
        CompareAndDisplaySummary();
    }

    public int savedMoney = PlayerPrefs.GetInt("money", 0);
    public int savedGlobalSatisfactionRate = PlayerPrefs.GetInt("globalSatisfactionRate", 0);
    public int savedSuccessRate = PlayerPrefs.GetInt("success_rate", 0);
    public int savedGlobalNumberOfStudents = PlayerPrefs.GetInt("globalNumberOfStudents", 0);
    public int savedGlobalNumberStudentCapacity = PlayerPrefs.GetInt("globalNumberStudentCapacity", 0);
    public int savedGlobalNumberOfStudentsInWorkStudy = PlayerPrefs.GetInt("globalNumberOfStudentsInWorkStudy", 0);
    public int savedGlobalNumberOfTeachers = PlayerPrefs.GetInt("globalNumberOfTeachers", 0);
    public int savedGlobalNumberSalaryOfTeachers = PlayerPrefs.GetInt("globalNumberSalaryOfTeachers", 0);
    public int savedGlobalNumberOfBuildings = PlayerPrefs.GetInt("globalNumberOfBuildings", 0);
    public int savedGlobalEnergyCost = PlayerPrefs.GetInt("globalEnergyCost", 0);
    public int savedAttractionRate = PlayerPrefs.GetInt("attractionRate", 0);
    public int savedQuotaGeneralTechnological = PlayerPrefs.GetInt("quotaGeneralTechnological", 0);
    public int savedErasmus = PlayerPrefs.GetInt("erasmus", 0);

    void CompareAndDisplaySummary()
    {

        Debug.Log("R�sum� des diff�rences :");
        Debug.Log("Argent : " + (playerVariables.Money - savedMoney));
        Debug.Log("Taux de satisfaction global : " + (playerVariables.GlobalSatisfactionRate - savedGlobalSatisfactionRate));
        Debug.Log("Taux de r�ussite : " + (playerVariables.SuccessRate - savedSuccessRate));
        Debug.Log("Nombre d'�tudiants global : " + (playerVariables.GlobalNumberOfStudents - savedGlobalNumberOfStudents));
        Debug.Log("Capacit� d'�tudiants global : " + (playerVariables.GlobalNumberStudentCapacity - savedGlobalNumberStudentCapacity));
        Debug.Log("Nombre d'�tudiants en alternance global : " + (playerVariables.GlobalNumberOfStudentsInWorkStudy - savedGlobalNumberOfStudentsInWorkStudy));
        Debug.Log("Nombre de professeurs global : " + (playerVariables.GlobalNumberOfTeachers - savedGlobalNumberOfTeachers));
        Debug.Log("Salaire des professeurs global : " + (playerVariables.GlobalNumberSalaryOfTeachers - savedGlobalNumberSalaryOfTeachers));
        Debug.Log("Nombre de b�timents global : " + (playerVariables.GlobalNumberOfBuildings - savedGlobalNumberOfBuildings));
        Debug.Log("Co�t �nerg�tique global : " + (playerVariables.GlobalEnergyCost - savedGlobalEnergyCost));
        Debug.Log("Taux d'attraction : " + (playerVariables.AttractionRate - savedAttractionRate));
        Debug.Log("Quota technologique g�n�ral : " + (playerVariables.QuotaGeneralTechnological - savedQuotaGeneralTechnological));
        Debug.Log("Erasmus : " + (playerVariables.Erasmus - savedErasmus));
    }
}
