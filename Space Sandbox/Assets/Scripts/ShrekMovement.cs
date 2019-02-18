using UnityEngine;

public class ShrekMovement : MonoBehaviour
{
    private float sizeMultiplier;
    private float rotationMultiplier;
    private float sizeConstant = 1;
    public Vector3 RotateAmount;

    void Awake()
    {
        sizeMultiplier = Random.Range(0, 5f);
        transform.localScale = new Vector3(sizeConstant * sizeMultiplier, sizeConstant * sizeMultiplier, sizeConstant * sizeMultiplier);

        rotationMultiplier = Random.Range(0, 360f);
        RotateAmount = new Vector3(rotationMultiplier, rotationMultiplier, rotationMultiplier);
    }

    void Update()
    {
        transform.Rotate(RotateAmount * (Time.deltaTime * Random.Range(0f, 1f)));
    }
}
