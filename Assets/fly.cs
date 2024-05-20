using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public Transform wing;
    public float wingRotationSpeed = 20f;
    public float wingRotationAngle = 15f;
    public float movementSpeed = 20f;

    private Vector3 initialWingPosition;
    private float currentRotationAngle = 0f;
    private bool isFlappingUp = true;

    void Start()
    {
        // Store the initial position of the wing
        initialWingPosition = wing.localPosition;
    }

    void Update()
    {
        // Rotate the wing up and down
        if (isFlappingUp)
        {
            currentRotationAngle += wingRotationSpeed * Time.deltaTime;
            if (currentRotationAngle >= wingRotationAngle)
                isFlappingUp = false;
        }
        else
        {
            currentRotationAngle -= wingRotationSpeed * Time.deltaTime;
            if (currentRotationAngle <= -wingRotationAngle)
                isFlappingUp = true;
        }

        // Apply the rotation to the wing
        Quaternion wingRotation = Quaternion.Euler(0f, 0f, currentRotationAngle);
        wing.localPosition = initialWingPosition; // Reset the wing position
        wing.localRotation = wingRotation;

        // Move the object forward
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }
}