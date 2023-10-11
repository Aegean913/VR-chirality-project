using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class XRButtonInput : MonoBehaviour
{
    public InputAction action; // Declares action to be set in editor
    public UnityEvent eventOnPress; // Declares event (list of actions) that occurs when invoked

    private void OnEnable()
    {
        // When object is active, check for input
        action.Enable();
        action.performed += openReset;
    }

    private void OnDisable()
    {
        // Stop checking input when object is not active
        action.Disable();
        action.performed -= openReset;
    }

    private void openReset(InputAction.CallbackContext context)
    {
        eventOnPress.Invoke();
    }
}
