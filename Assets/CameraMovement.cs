using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementDistance;
    public float movementSpeed;

    private Vector3 initialPosition;
    private int movingUp = 1;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.y >= initialPosition.y + movementDistance)
        {
            movingUp = -1;
        }
        else if (transform.position.y <= initialPosition.y)
        {
            movingUp = 1;
        }

        transform.position += new Vector3(0, movingUp * movementSpeed * Time.deltaTime, 0);
    }
}

