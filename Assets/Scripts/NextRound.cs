using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using static UnityEngine.GraphicsBuffer;

public class NextRound : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    [SerializeField] GameObject summer;
    [SerializeField] GameObject autumn;
    [SerializeField] GameObject winter;
    [SerializeField] GameObject spring;
    [SerializeField] Material grass;
    [SerializeField] Material tree;
    [SerializeField] GameObject directionalLight;
    public void Awake()
    {
        playerVariables.trimester = 1;
        SwitchSeason();
    }
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
                building.EnergyCost = (int)(building.EnergyCost * 1.06);
            }
            playerVariables.Money -= cost;
            playerVariables.trimester = 0;
            playerVariables.year++;
        }
        playerVariables.trimester++;
        SwitchSeason();
        playerVariables.UpdateData();
    }

    private void SwitchSeason()
    {
        summer.SetActive(false);
        autumn.SetActive(false);
        winter.SetActive(false);
        spring.SetActive(false);
        RenderSettings.fog = false;
        switch (playerVariables.trimester)
        {
            case 1:
                SetSummer();
                break;
            case 2:
                SetAutumn();
                break;
            case 3:
                SetWinter();
                break;
            case 4:
                SetSpring();
                break;
        }
    }

    private void SetSpring()
    {
        Debug.Log("SetSpring");
        summer.SetActive(false);
        autumn.SetActive(false);
        winter.SetActive(false);
        grass.color = new Color(80f / 255.0f, 142f / 255.0f, 52f / 255.0f);
        tree.color = new Color(48f / 255.0f, 113f / 255.0f, 53f / 255.0f);
        //directionalLight.transform.rotation = Quaternion.Euler(40, 100, 0);
    }

    private void SetWinter()
    {
        Debug.Log("SetWinter");
        winter.SetActive(true);
        grass.color = new Color(255f / 255.0f, 255f / 255.0f, 255f / 255.0f);
        tree.color = new Color(96f / 255.0f, 96f / 255.0f, 96f / 255.0f);
        RenderSettings.fogDensity = 0.005f;
        RenderSettings.fog = true;
        //directionalLight.transform.rotation = Quaternion.Euler(35, 100, 0);
    }

    private void SetAutumn()
    {
        Debug.Log("SetAutumn");
        autumn.SetActive(true);
        grass.color = new Color(60f / 255.0f, 100f / 255.0f, 60f / 255.0f);
        tree.color = new Color(145f / 255.0f, 102f / 255.0f, 37f / 255.0f);
        RenderSettings.fogDensity = 0.008f;
        RenderSettings.fog = true;
        //directionalLight.transform.rotation = Quaternion.Euler(45, 100, 0);
    }

    private void SetSummer()
    {
        Debug.Log("SetSummer");
        summer.SetActive(true);
        grass.color = new Color(96f / 255.0f, 142f / 255.0f, 52f / 255.0f);
        tree.color = new Color(48f / 255.0f, 113f / 255.0f, 53f / 255.0f);
        //directionalLight.transform.rotation = Quaternion.Euler(50, 100, 0);
    }

    private int CalculNextMoney()
    {
        // Nouveau trimestre
        int tempMoney = playerVariables.Money;
        tempMoney += 1000000;
        tempMoney += (int)(playerVariables.GlobalNumberOfStudentsInWorkStudy * 6000 * 0.16);
        return tempMoney;
    }
}