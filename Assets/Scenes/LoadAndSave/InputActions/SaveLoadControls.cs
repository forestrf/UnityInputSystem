// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/LoadAndSave/InputActions/SaveLoadControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SaveLoadControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SaveLoadControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SaveLoadControls"",
    ""maps"": [
        {
            ""name"": ""SaveLoadData"",
            ""id"": ""0c575e90-c121-4dae-8299-e97eefde73df"",
            ""actions"": [
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""b0fefeca-d8f3-4668-abe5-528eb39b4842"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Load"",
                    ""type"": ""Button"",
                    ""id"": ""38c3de28-93a9-4d17-b82e-b39226c8f9a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a24f9b96-8895-4834-a271-c3f3659064eb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""defef123-37c1-4333-a838-293d2875d533"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Load"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SaveLoadData
        m_SaveLoadData = asset.FindActionMap("SaveLoadData", throwIfNotFound: true);
        m_SaveLoadData_Save = m_SaveLoadData.FindAction("Save", throwIfNotFound: true);
        m_SaveLoadData_Load = m_SaveLoadData.FindAction("Load", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // SaveLoadData
    private readonly InputActionMap m_SaveLoadData;
    private ISaveLoadDataActions m_SaveLoadDataActionsCallbackInterface;
    private readonly InputAction m_SaveLoadData_Save;
    private readonly InputAction m_SaveLoadData_Load;
    public struct SaveLoadDataActions
    {
        private @SaveLoadControls m_Wrapper;
        public SaveLoadDataActions(@SaveLoadControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Save => m_Wrapper.m_SaveLoadData_Save;
        public InputAction @Load => m_Wrapper.m_SaveLoadData_Load;
        public InputActionMap Get() { return m_Wrapper.m_SaveLoadData; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SaveLoadDataActions set) { return set.Get(); }
        public void SetCallbacks(ISaveLoadDataActions instance)
        {
            if (m_Wrapper.m_SaveLoadDataActionsCallbackInterface != null)
            {
                @Save.started -= m_Wrapper.m_SaveLoadDataActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_SaveLoadDataActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_SaveLoadDataActionsCallbackInterface.OnSave;
                @Load.started -= m_Wrapper.m_SaveLoadDataActionsCallbackInterface.OnLoad;
                @Load.performed -= m_Wrapper.m_SaveLoadDataActionsCallbackInterface.OnLoad;
                @Load.canceled -= m_Wrapper.m_SaveLoadDataActionsCallbackInterface.OnLoad;
            }
            m_Wrapper.m_SaveLoadDataActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
                @Load.started += instance.OnLoad;
                @Load.performed += instance.OnLoad;
                @Load.canceled += instance.OnLoad;
            }
        }
    }
    public SaveLoadDataActions @SaveLoadData => new SaveLoadDataActions(this);
    public interface ISaveLoadDataActions
    {
        void OnSave(InputAction.CallbackContext context);
        void OnLoad(InputAction.CallbackContext context);
    }
}
