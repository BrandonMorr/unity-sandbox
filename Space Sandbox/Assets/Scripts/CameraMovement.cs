using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    public bool invertCamera = false;

    private float pitch = 0f;
    private float yaw = 0f;

    void Update()
    {
        // First touch input will control the camera rotation
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            int inverted = invertCamera == true ? 1 : -1;

            pitch += Input.GetTouch(0).deltaPosition.y * speed * inverted * Time.deltaTime;
            yaw += Input.GetTouch(0).deltaPosition.x * speed * inverted * Time.deltaTime;

            transform.eulerAngles = new Vector3(pitch, yaw, 0);
        }
    }
}
