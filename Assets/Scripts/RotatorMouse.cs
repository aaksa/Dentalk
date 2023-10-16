using UnityEngine;
using System.Collections;
using UI.ThreeDimensional;
using UnityEngine.EventSystems;

public class MouseRotator : MonoBehaviour
{
    public UIObject3D objek;

    public GameObject Box;

    public float rotationSpeed = 30.0f; // Adjust the rotation speed as needed
    public float rotationAngle = 125.0f; // The angle to rotate

    private bool isRotating = false;
    private Vector3 mouseStartPos;

    private bool isClick;

    private Coroutine rotationCoroutine;

    private void Start()
    {
        rotationCoroutine = StartCoroutine(RotateLoop());
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // Store the starting mouse position
            mouseStartPos = Input.mousePosition;
            isRotating = true;
            StopCoroutine(rotationCoroutine);
        }

        if (Input.GetMouseButtonUp(0) && isRotating)
        {
            isRotating = false;
            rotationCoroutine = StartCoroutine(RotateLoop());

        }

        if (isRotating)
        {
            // Calculate the mouse delta position
            Vector3 mouseDelta = Input.mousePosition - mouseStartPos;

            // Calculate the rotation amount based on the mouse movement
            float rotationX = mouseDelta.y * rotationSpeed * Time.deltaTime;
            float rotationY = -mouseDelta.x * rotationSpeed * Time.deltaTime; // Inverted for more intuitive rotation
            float rotationZ = 0; // You can add Z-axis rotation here if needed

            // Apply the rotation to the object
            objek.TargetRotation += new Vector3(rotationX, rotationY, rotationZ);

            // Store the current mouse position for the next frame
            mouseStartPos = Input.mousePosition;

        }

    }

    private IEnumerator RotateLoop()
    {
        while (true)
        {
            float currentYRotation = objek.TargetRotation.y;
            float targetYRotation = rotationAngle;

            // Smoothly interpolate the rotation from the current angle to the target angle
            float t = 0;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (rotationSpeed / 125.0f); // Adjust the speed by dividing by 45 for 45 degrees rotation
                float newYRotation = Mathf.Lerp(currentYRotation, targetYRotation, t);
                objek.TargetRotation = new Vector3(0, newYRotation, 0);
                yield return null;
            }

            // Swap the target angle for the next iteration
            rotationAngle = (rotationAngle == 125.0f) ? 225.0f : 125.0f;

            yield return new WaitForSeconds(1.0f); // Wait for a moment at the new rotation angle
        }
    }


    //bool IsMouseInsideBox()
    //{
    //    if (Box != null)
    //    {
    //        RectTransform canvasRect = Box.transform.parent.GetComponent<RectTransform>();
    //        Vector2 mousePosition = Input.mousePosition;

    //        // Convert the mouse position to local position within the Canvas
    //        Vector2 localMousePosition;
    //        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, mousePosition, null, out localMousePosition))
    //        {
    //            Rect rect = new Rect(Vector2.zero, canvasRect.rect.size);
    //            return rect.Contains(localMousePosition);
    //        }
    //    }

    //    return false; // Box GameObject is not assigned
    //}

}
