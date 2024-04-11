using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 initialpox;
    // Start is called before the first frame update
    void Start()
    {
        initialpox = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += 2f * Time.deltaTime;
        transform.position = pos;

        if (pos.x > initialpox.x + 50)
        {
            pos.x = initialpox.x;
            transform.position = pos;
        }
    }
}
