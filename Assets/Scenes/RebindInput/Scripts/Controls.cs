using System;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Samples.RebindUI
{
    public class Controls : MonoBehaviour
    {
        Rebinding_01 rebinding;

        // Start is called before the first frame update
        void Awake()
        {
            rebinding = new Rebinding_01();
        }

        // Update is called once per frame
        public void RebindingEventStart(RebindActionUI component, InputActionRebindingExtensions.RebindingOperation rebindingOperation)
        {
            Debug.Log("RebindingEventStart");
        }
    }

}