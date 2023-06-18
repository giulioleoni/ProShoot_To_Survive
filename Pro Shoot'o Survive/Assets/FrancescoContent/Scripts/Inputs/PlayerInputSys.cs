//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/FrancescoContent/Scripts/Inputs/PlayerInputSystem.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputSys: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSys()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""PlayerInputs"",
            ""id"": ""8b445174-f6d1-4a54-ba59-537134e83e28"",
            ""actions"": [
                {
                    ""name"": ""MouseDeltaDir"",
                    ""type"": ""Value"",
                    ""id"": ""20c23aac-ef15-4602-a15c-da2ae7705a4b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2,StickDeadzone(min=0.5,max=1),InvertVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveDir"",
                    ""type"": ""Value"",
                    ""id"": ""d1c316ee-1649-44d0-8c0e-22e6b090b2fd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""eeeddac3-6a6e-4e8d-96a7-81679c91d520"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""c0f1fc9e-3d4a-426c-8bf5-cbb95d1d0a2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""ed817106-8be4-4574-8fee-c4ab18f2b84c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ThrowGrenade"",
                    ""type"": ""Value"",
                    ""id"": ""d90455d8-f6fb-4e1b-91e0-823a717de61a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Value"",
                    ""id"": ""dab2d8fd-78cf-495d-9f39-2a48cc1da6fd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""301167d8-bf38-4764-9ef3-760dd44bde70"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDeltaDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffadc8ac-191d-4e4d-90bf-7ae592760faa"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDeltaDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dir"",
                    ""id"": ""649b0d87-ba8d-49e0-8277-236baebdd1b2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDir"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""c406fe01-be87-4556-bb56-f4cefa1356a4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""d98f60e5-8e44-4ce0-9135-05f64583e23e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""a059a825-61f7-4625-8bdd-f244b3b70149"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""9870d687-2321-455f-9b61-b2f0fa4fad2f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efff73e4-8a03-44cf-b33d-5be13bd50415"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97aa97d6-823c-40af-a845-ce9eae457942"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8672cca-a649-433c-9a7a-e9225ba20cd5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c21dcc57-27cd-4f45-bb03-5835767f7381"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2522c4ab-dd7e-417f-9224-34f13dac733a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5405718d-10a9-4e24-8e29-eab6562133cd"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowGrenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c7302d2-2350-4e73-be7e-0fe6bfda17ff"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowGrenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08e8dd3f-d26a-455e-9f2a-6a1843c81088"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowGrenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""117df93a-9a90-4d25-81f1-b72e658faaea"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c68acce-6f82-49de-8798-cc7681bbdfe9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba1fa025-9be5-42b7-8c96-d732fc18caf0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1606f27-3799-46ec-b04f-0b06323da967"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInputs
        m_PlayerInputs = asset.FindActionMap("PlayerInputs", throwIfNotFound: true);
        m_PlayerInputs_MouseDeltaDir = m_PlayerInputs.FindAction("MouseDeltaDir", throwIfNotFound: true);
        m_PlayerInputs_MoveDir = m_PlayerInputs.FindAction("MoveDir", throwIfNotFound: true);
        m_PlayerInputs_Jump = m_PlayerInputs.FindAction("Jump", throwIfNotFound: true);
        m_PlayerInputs_Aim = m_PlayerInputs.FindAction("Aim", throwIfNotFound: true);
        m_PlayerInputs_Shoot = m_PlayerInputs.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerInputs_ThrowGrenade = m_PlayerInputs.FindAction("ThrowGrenade", throwIfNotFound: true);
        m_PlayerInputs_PauseMenu = m_PlayerInputs.FindAction("PauseMenu", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerInputs
    private readonly InputActionMap m_PlayerInputs;
    private List<IPlayerInputsActions> m_PlayerInputsActionsCallbackInterfaces = new List<IPlayerInputsActions>();
    private readonly InputAction m_PlayerInputs_MouseDeltaDir;
    private readonly InputAction m_PlayerInputs_MoveDir;
    private readonly InputAction m_PlayerInputs_Jump;
    private readonly InputAction m_PlayerInputs_Aim;
    private readonly InputAction m_PlayerInputs_Shoot;
    private readonly InputAction m_PlayerInputs_ThrowGrenade;
    private readonly InputAction m_PlayerInputs_PauseMenu;
    public struct PlayerInputsActions
    {
        private @PlayerInputSys m_Wrapper;
        public PlayerInputsActions(@PlayerInputSys wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseDeltaDir => m_Wrapper.m_PlayerInputs_MouseDeltaDir;
        public InputAction @MoveDir => m_Wrapper.m_PlayerInputs_MoveDir;
        public InputAction @Jump => m_Wrapper.m_PlayerInputs_Jump;
        public InputAction @Aim => m_Wrapper.m_PlayerInputs_Aim;
        public InputAction @Shoot => m_Wrapper.m_PlayerInputs_Shoot;
        public InputAction @ThrowGrenade => m_Wrapper.m_PlayerInputs_ThrowGrenade;
        public InputAction @PauseMenu => m_Wrapper.m_PlayerInputs_PauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInputsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInputsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInputsActionsCallbackInterfaces.Add(instance);
            @MouseDeltaDir.started += instance.OnMouseDeltaDir;
            @MouseDeltaDir.performed += instance.OnMouseDeltaDir;
            @MouseDeltaDir.canceled += instance.OnMouseDeltaDir;
            @MoveDir.started += instance.OnMoveDir;
            @MoveDir.performed += instance.OnMoveDir;
            @MoveDir.canceled += instance.OnMoveDir;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @ThrowGrenade.started += instance.OnThrowGrenade;
            @ThrowGrenade.performed += instance.OnThrowGrenade;
            @ThrowGrenade.canceled += instance.OnThrowGrenade;
            @PauseMenu.started += instance.OnPauseMenu;
            @PauseMenu.performed += instance.OnPauseMenu;
            @PauseMenu.canceled += instance.OnPauseMenu;
        }

        private void UnregisterCallbacks(IPlayerInputsActions instance)
        {
            @MouseDeltaDir.started -= instance.OnMouseDeltaDir;
            @MouseDeltaDir.performed -= instance.OnMouseDeltaDir;
            @MouseDeltaDir.canceled -= instance.OnMouseDeltaDir;
            @MoveDir.started -= instance.OnMoveDir;
            @MoveDir.performed -= instance.OnMoveDir;
            @MoveDir.canceled -= instance.OnMoveDir;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @ThrowGrenade.started -= instance.OnThrowGrenade;
            @ThrowGrenade.performed -= instance.OnThrowGrenade;
            @ThrowGrenade.canceled -= instance.OnThrowGrenade;
            @PauseMenu.started -= instance.OnPauseMenu;
            @PauseMenu.performed -= instance.OnPauseMenu;
            @PauseMenu.canceled -= instance.OnPauseMenu;
        }

        public void RemoveCallbacks(IPlayerInputsActions instance)
        {
            if (m_Wrapper.m_PlayerInputsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInputsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInputsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInputsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInputsActions @PlayerInputs => new PlayerInputsActions(this);
    public interface IPlayerInputsActions
    {
        void OnMouseDeltaDir(InputAction.CallbackContext context);
        void OnMoveDir(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnThrowGrenade(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
    }
}
