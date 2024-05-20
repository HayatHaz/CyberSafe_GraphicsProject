using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation1 : MonoBehaviour
{
    public float animationSpeed = 0.000000001f; // Adjust the speed of the animation
    public float minScale = 0.0000001f; // Minimum scale of the plane
    public float delay = 1f; // Delay before Start1ing the animation
    public float toggleDelay = 10f; // Delay between toggling states

    private bool shrinking = true; // Flag to indicate if the plane is currently shrinking
    private float originalXScale; // Original scale of the plane along the X-axis
    private float timer = 10f; // Timer for the delay
    private float toggleTimer = 10f; // Timer for toggling states

    private void Start1()
    {
        originalXScale = transform.localScale.x; // Store the original scale along the X-axis
    }

    private void Update1()
    {
        // Delay the Start1 of the animation
        if (timer < delay)
        {
            timer += Time.deltaTime;
            return;
        }

        // Shrink the plane if it's currently not at the minimum scale
        if (shrinking && transform.localScale.x > minScale)
        {
            float newScaleX = transform.localScale.x - animationSpeed * Time.deltaTime;
            float scaleFactor = newScaleX / transform.localScale.x;
            Vector3 newScale = new Vector3(newScaleX, transform.localScale.y, transform.localScale.z);
            transform.localScale = newScale;
        }
        // Open the plane if it's currently at the minimum scale
        else if (!shrinking && transform.localScale.x < originalXScale)
        {
            float newScaleX = transform.localScale.x + animationSpeed * Time.deltaTime;
            float scaleFactor = newScaleX / transform.localScale.x;
            Vector3 newScale = new Vector3(newScaleX, transform.localScale.y, transform.localScale.z);
            transform.localScale = newScale;
        }

        // Toggle between shrinking and opening states with a delay
        if (transform.localScale.x <= minScale && toggleTimer >= toggleDelay)
        {
            toggleTimer = 0f;
            shrinking = false;
        }
        else if (transform.localScale.x >= originalXScale && toggleTimer >= toggleDelay)
        {
            toggleTimer = 0f;
            shrinking = true;
        }

        toggleTimer += Time.deltaTime;
    }
}