using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetRecapUI : MonoBehaviour
{
    public GameObject recapUI;
    public PlayerVariables playerVariables;


    public TextMeshProUGUI satisfactionRate;
    public TextMeshProUGUI satisfactionRateProgress;

    public TextMeshProUGUI successRate;
    public TextMeshProUGUI successRateProgress;

    public TextMeshProUGUI money;
    public TextMeshProUGUI moneyProgress;

    public TextMeshProUGUI energyFacture;
    public TextMeshProUGUI batimentFacture;

    public TextMeshProUGUI studentNumber;
    public TextMeshProUGUI studentNumberProgress;
    public TextMeshProUGUI studentNumberInWorkStudy;
    public TextMeshProUGUI studentNumberCapacity;

    public TextMeshProUGUI teacherNumber;
    public TextMeshProUGUI teacherNumberProgress;

    public TextMeshProUGUI teacherStudentRatio;

    public void SetValue()
    {
        recapUI.SetActive(true);
        satisfactionRate.text = playerVariables.GlobalSatisfactionRate.ToString();
        satisfactionRateProgress.text = (playerVariables.GlobalSatisfactionRate - playerVariables.atStartglobalSatisfactionRate) > 0 ? "+" + (playerVariables.GlobalSatisfactionRate - playerVariables.atStartglobalSatisfactionRate).ToString() : (playerVariables.GlobalSatisfactionRate - playerVariables.atStartglobalSatisfactionRate).ToString();

        successRate.text = playerVariables.SuccessRate.ToString();
        successRateProgress.text = (playerVariables.SuccessRate - playerVariables.atStartsuccess_rate) > 0 ? "+" + (playerVariables.SuccessRate - playerVariables.atStartsuccess_rate).ToString() : (playerVariables.SuccessRate - playerVariables.atStartsuccess_rate).ToString();

        money.text = playerVariables.Money.ToString();
        moneyProgress.text = (playerVariables.Money - playerVariables.atStartRoundMoney) > 0 ? "+" + (playerVariables.Money - playerVariables.atStartRoundMoney).ToString() : (playerVariables.Money - playerVariables.atStartRoundMoney).ToString();

        energyFacture.text = playerVariables.GlobalEnergyCost.ToString();
        batimentFacture.text = "Pas encore implémenté";

        studentNumber.text = playerVariables.GlobalNumberOfStudents.ToString();
        studentNumberProgress.text = (playerVariables.GlobalNumberOfStudents - playerVariables.atStartglobalNumberOfStudents) > 0 ? "+" + (playerVariables.GlobalNumberOfStudents - playerVariables.atStartglobalNumberOfStudents).ToString() : (playerVariables.GlobalNumberOfStudents - playerVariables.atStartglobalNumberOfStudents).ToString();
        studentNumberInWorkStudy.text = playerVariables.GlobalNumberOfStudentsInWorkStudy.ToString();
        studentNumberCapacity.text = playerVariables.GlobalNumberStudentCapacity.ToString();

        teacherNumber.text = playerVariables.GlobalNumberOfTeachers.ToString();
        teacherNumberProgress.text = (playerVariables.GlobalNumberOfTeachers - playerVariables.atStartglobalNumberOfTeachers) > 0 ? "+" + (playerVariables.GlobalNumberOfTeachers - playerVariables.atStartglobalNumberOfTeachers).ToString() : (playerVariables.GlobalNumberOfTeachers - playerVariables.atStartglobalNumberOfTeachers).ToString();

        teacherStudentRatio.text = "1/"+playerVariables.GlobalNumberOfStudents/ playerVariables.GlobalNumberOfTeachers;




    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
