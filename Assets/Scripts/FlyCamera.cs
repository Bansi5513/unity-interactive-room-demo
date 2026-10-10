using UnityEngine;

public class FlyCamera : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float lookSpeed = 2f;
    private float rotX = 0f;

    void Update()
    {
        // Movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float y = 0f;
        if (Input.GetKey(KeyCode.E)) y = 1f;
        if (Input.GetKey(KeyCode.Q)) y = -1f;
        transform.parent.Translate(new Vector3(h, y, v) 
                                   * moveSpeed * Time.deltaTime);

        // Rotation with any mouse button
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;
        
        if (mouseX != 0 || mouseY != 0)
        {
            rotX -= mouseY;
            rotX = Mathf.Clamp(rotX, -80f, 80f);
            transform.localRotation = Quaternion.Euler(rotX, 0f, 0f);
            transform.parent.Rotate(0f, mouseX, 0f);
        }
    }
}