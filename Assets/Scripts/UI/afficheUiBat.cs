using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class afficheUiBat : MonoBehaviour
{
    [SerializeField] string name;


    [SerializeField] GameObject buildUI;

    [SerializeField] GameObject checker;

    void Start()
    {

        
    }

    private void OnMouseDown()
    {
        
        if (!checker.active)
        {
            Building building = new Building(name);
            buildUI.SetActive(true);
            checker.SetActive(true);


            TextMeshProUGUI textComponent = buildUI.transform.Find("Popup03_Dark/TopFrame/Text_Title").GetComponent<TextMeshProUGUI>();


            Component components = buildUI.transform.Find("Popup03_Dark/Panel_Left");

            components.transform.Find("age").transform.Find("AgeText").GetComponent<TextMeshProUGUI>().text = building.Age.ToString() + " ans";

            components.transform.Find("déscription").transform.Find("DéscriptionText").GetComponent<TextMeshProUGUI>().text = building.Description;


            components = buildUI.transform.Find("Popup03_Dark/Panel_Middle");

            //Nombres_d'etudiantsText

            components.transform.Find("Nombres_d'etudiantsText").GetComponent<TextMeshProUGUI>().text = building.StudentNumber + " éleves";

            components.transform.Find("capacitéText").GetComponent<TextMeshProUGUI>().text = building.StudentCapacity + " éleves";
            components.transform.Find("AlternanceNombre").GetComponent<TextMeshProUGUI>().text = building.StudentInWorkStudy + " éleves";


            components.transform.Find("FactureText").GetComponent<TextMeshProUGUI>().text = "-" +building.EnergyCost + " €";

            components.transform.Find("Slider16_Light/BackFrame/FillArea/Nombre").GetComponent<TextMeshProUGUI>().text = building.TeacherNumber.ToString();

            components.transform.Find("Btn_Rectangle00_n_Common_Green/Text").GetComponent<TextMeshProUGUI>().text = "Améliorer " + building.BuildingCostToUpgrade.ToString() + " €";
            //si le batiment est deja amelioré c'est a dire 0 desactiver le bouton

            if (building.BuildingCostToUpgrade == 0)
            {
                components.transform.Find("Btn_Rectangle00_n_Common_Green").gameObject.SetActive(false);
            }



            textComponent.text = name;
            


        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
