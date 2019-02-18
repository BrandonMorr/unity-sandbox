using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float spinforce;

    private bool isSpinning = false;

    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(0, spinforce * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
    }

    public void ChangeDirection()
    {
        isSpinning = !isSpinning;
    }
}
