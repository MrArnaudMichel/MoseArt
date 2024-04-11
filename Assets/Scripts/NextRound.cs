using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRound : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    public void NextRoundAction()
    {
        if (playerVariables.trimester % 4 == 0)
        {
            playerVariables.Money = CalculNextMoney();
            int cost = 0;
            foreach (Building building in playerVariables.Buildings)
            {
                cost += building.EnergyCost;
                if (building.SuccessRate > 75 && building.StudentAppreciation > 75)
                {
                    building.StudentNumber = (int)(building.StudentNumber * 1.05);
                    if (building.StudentNumber > building.StudentCapacity)
                    {
                        building.StudentNumber = building.StudentCapacity;
                    }
                }
                else if (building.SuccessRate < 50 || building.StudentAppreciation > 50)
                {
                    building.StudentNumber = (int)(building.StudentNumber * 0.95);
                }
                if (building.StudentNumber / 30 > building.TeacherNumber)
                {
                    building.TeacherNumber = (int)(building.TeacherNumber * 0.95);
                }

            }
            playerVariables.Money -= cost;
            playerVariables.trimester = 1;
            playerVariables.year++;
        }
    }

    private int CalculNextMoney()
    {
        // Nouveau trimestre
        int tempMoney = playerVariables.Money;
        tempMoney += 1000000;
        tempMoney += (int)(playerVariables.GlobalNumberOfStudentsInWorkStudy * 6000 * 0.16);
        playerVariables.trimester = 1;
        playerVariables.year++;
        return tempMoney;
    }
}
