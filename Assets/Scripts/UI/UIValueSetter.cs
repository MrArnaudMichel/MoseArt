using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIValueSetter : MonoBehaviour
{
    [SerializeField] PlayerVariables playerVariables;
    [SerializeField] TextMeshProUGUI globalSatisfactionRate;
    [SerializeField] TextMeshProUGUI successRate;
    [SerializeField] TextMeshProUGUI money;

    // Update is called once per frame
    void Update()
    {
        globalSatisfactionRate.text = playerVariables.GlobalSatisfactionRate.ToString();
        successRate.text = playerVariables.SuccessRate.ToString();
        money.text = playerVariables.Money.ToString();
    }
}
