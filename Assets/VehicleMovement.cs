using UnityEngine;
using UnityEngine.InputSystem;

public class VehicleMovement : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 80f;

    void Update()
    {
        float move = 0f;
        float turn = 0f;

        if (Keyboard.current.upArrowKey.isPressed) move = 1f;
        if (Keyboard.current.downArrowKey.isPressed) move = -1f;
        if (Keyboard.current.leftArrowKey.isPressed) turn = -1f;
        if (Keyboard.current.rightArrowKey.isPressed) turn = 1f;

        transform.Translate(Vector3.forward * move * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);
    }
}