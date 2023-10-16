using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI.ThreeDimensional;

public class Rotator : MonoBehaviour
{
    public UIObject3D objeknya;
    public float rotationSpeed = 30.0f; // Adjust the rotation speed as needed
    public float rotationAngle = 45.0f; // The angle to rotate

    private Coroutine rotationCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        // Start the rotation loop
        rotationCoroutine = StartCoroutine(RotateLoop());
    }

    // Update is called once per frame
    void Update()
    {
        // If you want to stop the rotation, you can stop the coroutine like this:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rotationCoroutine != null)
            {
                StopCoroutine(rotationCoroutine);
            }
        }
    }

    private IEnumerator RotateLoop()
    {
        while (true)
        {
            float currentYRotation = objeknya.TargetRotation.y;
            float targetYRotation = rotationAngle;

            // Smoothly interpolate the rotation from the current angle to the target angle
            float t = 0;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (rotationSpeed / 45.0f); // Adjust the speed by dividing by 45 for 45 degrees rotation
                float newYRotation = Mathf.Lerp(currentYRotation, targetYRotation, t);
                objeknya.TargetRotation = new Vector3(0, newYRotation, 0);
                yield return null;
            }

            // Swap the target angle for the next iteration
            rotationAngle = (rotationAngle == 45.0f) ? -45.0f : 45.0f;

            yield return new WaitForSeconds(1.0f); // Wait for a moment at the new rotation angle
        }
    }
}
