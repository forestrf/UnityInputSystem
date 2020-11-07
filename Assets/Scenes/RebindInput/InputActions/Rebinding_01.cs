// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/RebindInput/InputActions/Rebinding_01.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Rebinding_01 : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Rebinding_01()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Rebinding_01"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""b2ef74c2-1fc9-4657-8ff5-97b25970a6ee"",
            ""actions"": [
                {
                    ""name"": ""KeyboardMove"",
                    ""type"": ""Value"",
                    ""id"": ""dbef3563-d572-45d1-8b82-86d8533b3769"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyboardInteract"",
                    ""type"": ""Button"",
                    ""id"": ""4ddf57de-9441-4d36-821b-416a3a846f66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControlerMove"",
                    ""type"": ""Value"",
                    ""id"": ""b762c0a0-0bde-4feb-9e7e-8fa3e0dfcb3b"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControlerInteract"",
                    ""type"": ""Button"",
                    ""id"": ""af043f0d-3349-46aa-98a9-86b7d3cfb172"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControlerLook"",
                    ""type"": ""Value"",
                    ""id"": ""1139b4ec-0c57-4f24-80e7-5018e8913db9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""3283e63a-aed7-45d6-8323-0251946b08cb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a921c6c0-a5bd-4d9c-8615-c11cb0b4c4d2"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7c4a309f-9c24-4bd8-938d-197d049c6e4b"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""55848a25-de0d-4b2c-ac3d-6cc214ec54e0"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""737618f0-64b1-4b05-beb3-3bd27fbd861e"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dfff7655-ebe7-4574-b621-18d57b651840"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd54161c-2f8e-4893-a0ae-c7cec7fb36ca"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ControlerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cbe5e1f-d73e-406e-8e63-5a5e25a5a15a"",
                    ""path"": ""<HID::Performance Designed Products Wired Fight Pad Pro for Nintendo Switch>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ControlerInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""451ab0df-aa32-40ff-b6b7-93719fcc1bcd"",
                    ""path"": ""<HID::Performance Designed Products Wired Fight Pad Pro for Nintendo Switch>/hat/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ControlerLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_KeyboardMove = m_Gameplay.FindAction("KeyboardMove", throwIfNotFound: true);
        m_Gameplay_KeyboardInteract = m_Gameplay.FindAction("KeyboardInteract", throwIfNotFound: true);
        m_Gameplay_ControlerMove = m_Gameplay.FindAction("ControlerMove", throwIfNotFound: true);
        m_Gameplay_ControlerInteract = m_Gameplay.FindAction("ControlerInteract", throwIfNotFound: true);
        m_Gameplay_ControlerLook = m_Gameplay.FindAction("ControlerLook", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_KeyboardMove;
    private readonly InputAction m_Gameplay_KeyboardInteract;
    private readonly InputAction m_Gameplay_ControlerMove;
    private readonly InputAction m_Gameplay_ControlerInteract;
    private readonly InputAction m_Gameplay_ControlerLook;
    public struct GameplayActions
    {
        private @Rebinding_01 m_Wrapper;
        public GameplayActions(@Rebinding_01 wrapper) { m_Wrapper = wrapper; }
        public InputAction @KeyboardMove => m_Wrapper.m_Gameplay_KeyboardMove;
        public InputAction @KeyboardInteract => m_Wrapper.m_Gameplay_KeyboardInteract;
        public InputAction @ControlerMove => m_Wrapper.m_Gameplay_ControlerMove;
        public InputAction @ControlerInteract => m_Wrapper.m_Gameplay_ControlerInteract;
        public InputAction @ControlerLook => m_Wrapper.m_Gameplay_ControlerLook;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @KeyboardMove.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKeyboardMove;
                @KeyboardMove.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKeyboardMove;
                @KeyboardMove.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKeyboardMove;
                @KeyboardInteract.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKeyboardInteract;
                @KeyboardInteract.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKeyboardInteract;
                @KeyboardInteract.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKeyboardInteract;
                @ControlerMove.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerMove;
                @ControlerMove.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerMove;
                @ControlerMove.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerMove;
                @ControlerInteract.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerInteract;
                @ControlerInteract.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerInteract;
                @ControlerInteract.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerInteract;
                @ControlerLook.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerLook;
                @ControlerLook.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerLook;
                @ControlerLook.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnControlerLook;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @KeyboardMove.started += instance.OnKeyboardMove;
                @KeyboardMove.performed += instance.OnKeyboardMove;
                @KeyboardMove.canceled += instance.OnKeyboardMove;
                @KeyboardInteract.started += instance.OnKeyboardInteract;
                @KeyboardInteract.performed += instance.OnKeyboardInteract;
                @KeyboardInteract.canceled += instance.OnKeyboardInteract;
                @ControlerMove.started += instance.OnControlerMove;
                @ControlerMove.performed += instance.OnControlerMove;
                @ControlerMove.canceled += instance.OnControlerMove;
                @ControlerInteract.started += instance.OnControlerInteract;
                @ControlerInteract.performed += instance.OnControlerInteract;
                @ControlerInteract.canceled += instance.OnControlerInteract;
                @ControlerLook.started += instance.OnControlerLook;
                @ControlerLook.performed += instance.OnControlerLook;
                @ControlerLook.canceled += instance.OnControlerLook;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnKeyboardMove(InputAction.CallbackContext context);
        void OnKeyboardInteract(InputAction.CallbackContext context);
        void OnControlerMove(InputAction.CallbackContext context);
        void OnControlerInteract(InputAction.CallbackContext context);
        void OnControlerLook(InputAction.CallbackContext context);
    }
}
