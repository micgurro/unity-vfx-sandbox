using UnityEngine;

[ExecuteInEditMode]
public class RotateObject : MonoBehaviour
{
    // Speed of rotation in degrees per second
    public float rotationSpeed = 90f;

    void Update()
    {
        // Calculate rotation for this frame
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Rotate the object around its Y-axis
        transform.Rotate(0, rotationAmount, 0);
    }
}