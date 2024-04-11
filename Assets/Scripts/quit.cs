using UnityEngine;

public class quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] GameObject ui;
    [SerializeField] GameObject check;


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("fuck");
        ui.SetActive(false);
        check.SetActive(false);
    }
}
