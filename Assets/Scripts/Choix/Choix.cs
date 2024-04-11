using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choix
{
    private int id;
    private string _name;
    private string question;
    private string reponse1;
    private string reponse2;
    private string reponse3;
    [SerializeField] PlayerVariables playerVariables;

    public Choix(int id)
    {
        foreach (var choixData in choixDatas)
        {
            if (choixData.id == id)
            {
                _name = choixData.Name;
                question = choixData.Question;
                reponse1 = choixData.Reponse1;
                reponse2 = choixData.Reponse2;
                reponse3 = choixData.Reponse3;
            }
        }
    }
    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public string Question
    {
        get => question;
        set => question = value;    
    }

    public string Reponse1
    {
        get => reponse1;
        set => reponse1 = value;
    }
    public string Reponse2
    {
        get => reponse2;
        set => reponse2 = value;
    }
    public string Reponse3
    {
        get => reponse3;
        set => reponse3 = value;
    }


    public List<ChoixData> choixDatas = new List<ChoixData>()
    {
        new ChoixData()
        {
            id = 0,
            Name = "Pandemie",
            Question = "Il y'a une présomption de pandémie qui pourrait grandement impacter la santé des étudiants, que voulez vous faire ?",
            Reponse1 = "Fermer les classes pendant 15 jours",
            Reponse2 = "Faire du semi-distancier",
            Reponse3 = "Garder les classes ouverte",
        },
        new ChoixData()
        {
            id = 1,
            Name = "Scandale académique",
            Question = "Un professeur a menacé d'un coup de pied au cul un éleve et fait du bruit sur les réseaux sociaux, que voulez vous faire ?",
            Reponse1 = "Ne pas communiquer sur la situation",
            Reponse2 = "Sinus de 0 ca fait 1",
            Reponse3 = "Enqueter et prendre des mesures disciplinaires",
        },
        new ChoixData()
        {
            id = 2,
            Name = "Froid Hivernal",
            Question = "Une grande vague de froid va frapper la région cette année et ca pourrait nous couter cher, que devrions nous faire ?",
            Reponse1 = "Fermer l'IUT temporairement",
            Reponse2 = "Baisser le chauffage",
            Reponse3 = "Laisser l'université ouverte avec le chauffage a la puissance maximale",
        }, 
        new ChoixData()
        {
            id = 3,
            Name = "Don de la CPER",
            Question = "Le Contrat de Plant Etat Régio (CPER) nous offre 4 millions pour rénover un batiment de l'IUT",
            Reponse1 = "Rénover le batiment Informatique",
            Reponse2 = "Rénover le batiment de Chimie",
            Reponse3 = "Garder l'argent pour d'autres projets",
        }
    };

    public class ChoixData
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Question { get; set; }
        public string Reponse1 { get; set; }
        public string Reponse2 { get; set; }
        public string Reponse3 { get; set; }
    }
}