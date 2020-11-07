using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ManualBinding : MonoBehaviour
{
    public InputAction inputAction;

    public InputActionReference inputActionReference;

    // Start is called before the first frame update
    void Start()
    {
        inputAction = new InputAction(binding: "<Gamepad>/buttonSouth");
        inputAction.AddBinding("<Mouse>/leftButton");
        Debug.Log(inputAction);
        Debug.Log(inputActionReference);

        inputAction.AddBinding(inputActionReference.action.bindings[0].ToString());
        Debug.Log(inputAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
