using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{
    PlayerControls controls;

    Vector2 move;
    Vector2 rotate;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.Grow.performed += ctx => Grow();

        controls.Gameplay.Shrink.performed += ctx => Shrink();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.Gameplay.Rotate.canceled += ctx => rotate = Vector2.zero;
    }

    void Grow() 
    {
        transform.localScale *= 1.1f;
    }

    void Shrink()
    {
        transform.localScale /= 1.1f;
    }

    void Update() 
    {
        Vector2 m = new Vector2(-move.x, move.y) * 4 * Time.deltaTime;
        transform.Translate(m, Space.World);

        Vector2 r = new Vector2(-rotate.y, - rotate.x) * 100 * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();   
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
