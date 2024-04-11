using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class setupUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI name;
    [SerializeField] TextMeshProUGUI question;
    [SerializeField] Button choix1;
    [SerializeField] Button choix2;
    [SerializeField] Button choix3;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void setup(int id)
    {
        this.gameObject.SetActive(true);
        Choix choix = new Choix(id);

        name.text = choix.Name;
        question.text = choix.Question;

        choix1.GetComponentInChildren<TextMeshProUGUI>().text = choix.Reponse1;
        choix2.GetComponentInChildren<TextMeshProUGUI>().text = choix.Reponse2;
        choix3.GetComponentInChildren<TextMeshProUGUI>().text = choix.Reponse3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
