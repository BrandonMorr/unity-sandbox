using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFly : MonoBehaviour
{
    public float playerSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + (Camera.main.transform.forward * playerSpeed * Time.deltaTime);
        }
    }
}
