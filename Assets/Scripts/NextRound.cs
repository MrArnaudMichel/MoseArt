using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    [SerializeField] GameObject dialogueObj;
    [SerializeField] SetRecapUI setRecapUI;
    public void Awake()
    {
        playerVariables.trimester = 1;
        SwitchSeason();
    }
    public void NextRoundAction()
    {
        if (playerVariables.year == 4)
        {
            ActiveEndGame();
            return;
        }
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
        setRecapUI.SetValue();
        playerVariables.SetValueAtStartRound();
        RandomEvent();
    }

    private void ActiveEndGame()
    {
        playerVariables.dialogueManager.mainUI.SetActive(false);
        playerVariables.dialogueManager.StartDialogue(12);
        // TODO: Implement end game UI
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
    public void RandomEvent()
    {
        int random = -1;
        int chance = -1;
        DialogueManager dialogueManager = dialogueObj.GetComponent<DialogueManager>();
        if (playerVariables.trimester == 3)
        {
            // Winter
            chance = UnityEngine.Random.Range(1, 5);
            if (chance == 1)
            {
                //VagueFroid.Start(playerVariables);
                Debug.Log("VagueFroid");
                dialogueManager.StartDialogue(10, 2);
                return;
            }
        }
        else
        {
            chance = UnityEngine.Random.Range(1, 50);
            switch (chance)
            {
                case 1:
                    //Pandemie.Start(playerVariables);
                    Debug.Log("Pandemie");
                    dialogueManager.StartDialogue(6, 0);
                    break;
                case 2:
                    //ScandaleAcademique.Start(playerVariables);
                    Debug.Log("ScandaleAcademique");
                    dialogueManager.StartDialogue(9, 1);
                    break;
                case 3:
                    Debug.Log("4M CPer");
                    dialogueManager.StartDialogue(2, 3);
                    break;
            }
        }
        

        if (chance ==1)
        {
            if (random == 1)
            {
                DonImportant.Start(playerVariables);
                Debug.Log("DonImportant");
                dialogueManager.StartDialogue(1);


            }
            else if (random == 2)
            {
                EleveTable.Start(playerVariables);
                Debug.Log("EleveTable");
                dialogueManager.StartDialogue(2);
            }
            else if (random == 3)
            {
                FuiteAmiante.Start(playerVariables);
                Debug.Log("FuiteAmiante");
                dialogueManager.StartDialogue(3);
            }
            else if (random == 4)
            {
                Guerre.Start(playerVariables);
                Debug.Log("Guerre");
                dialogueManager.StartDialogue(4);
            }
            else if (random == 5)
            {
                InnovatilonPedagogique.Start(playerVariables);
                Debug.Log("InnovatilonPedagogique");
                dialogueManager.StartDialogue(5);
            }
            else if (random == 6)
            {
                Pandemie.Start(playerVariables);
                Debug.Log("Pandemie");
                dialogueManager.StartDialogue(6);
            }
            else if (random == 7)
            {
                PanneMajeureIT.Start(playerVariables);
                Debug.Log("PanneMajeureIT");
                dialogueManager.StartDialogue(7);
            }
            else if (random == 8)
            {
                ReformeGouvernementale.Start(playerVariables);
                Debug.Log("ReformeGouvernementale");
                dialogueManager.StartDialogue(8);

            }
            else if (random == 9)
            {
                ScandaleAcademique.Start(playerVariables);
                Debug.Log("ScandaleAcademique");
                dialogueManager.StartDialogue(9);
            }
            else if (random == 10)
            {
                VagueFroid.Start(playerVariables);
                Debug.Log("VagueFroid");
                dialogueManager.StartDialogue(10);
            }
        }
        else
        {
            Debug.Log("Pas d'evenement");
        }
    }
}