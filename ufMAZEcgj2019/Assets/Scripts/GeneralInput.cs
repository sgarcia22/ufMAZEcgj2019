// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GeneralInput.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class GeneralInput : IInputActionCollection
{
    private InputActionAsset asset;
    public GeneralInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GeneralInput"",
    ""maps"": [
        {
            ""name"": ""KeyboardInput"",
            ""id"": ""26dc67bc-c9ec-4734-a71d-c59fd10b2531"",
            ""actions"": [
                {
                    ""name"": ""ForwardBackwardMovement"",
                    ""type"": ""Button"",
                    ""id"": ""0523ccc4-ac01-47ea-8b9a-c2933024fcd2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""SidewaysMovement"",
                    ""type"": ""Button"",
                    ""id"": ""520c42e7-c1d3-47bb-a4f8-b023ee4bbe70"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ForwardBackward"",
                    ""id"": ""db839a80-1078-443d-a0f6-5d473b69720e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardBackwardMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""0d26b59e-3f3b-4de3-a850-bf73ced38bca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardBackwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""7ddba581-49dd-421d-876f-7b79f4ef3e9e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardBackwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""SidewaysMovement"",
                    ""id"": ""196c6abf-1ae2-47f2-ae06-05c1d0c9a097"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SidewaysMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""80f300f5-d97e-4fda-94c8-61be67f15759"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SidewaysMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""065932b8-7174-4aa4-9794-0f7a60ef197c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SidewaysMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MouseInput"",
            ""id"": ""722d90fa-2901-477c-906b-9ff809b25758"",
            ""actions"": [
                {
                    ""name"": ""VerticalLook"",
                    ""type"": ""Value"",
                    ""id"": ""66e36a99-15fb-46cc-a3a7-ad0cbdf1fcd8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HorizontalLook"",
                    ""type"": ""Value"",
                    ""id"": ""01e35c8e-a372-495f-88a3-fae564e5311b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91ee8c09-6853-4fea-92e7-58bea28135f0"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0184a8c9-16db-4c15-9f65-5ad5dac92e34"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyboardInput
        m_KeyboardInput = asset.GetActionMap("KeyboardInput");
        m_KeyboardInput_ForwardBackwardMovement = m_KeyboardInput.GetAction("ForwardBackwardMovement");
        m_KeyboardInput_SidewaysMovement = m_KeyboardInput.GetAction("SidewaysMovement");
        // MouseInput
        m_MouseInput = asset.GetActionMap("MouseInput");
        m_MouseInput_VerticalLook = m_MouseInput.GetAction("VerticalLook");
        m_MouseInput_HorizontalLook = m_MouseInput.GetAction("HorizontalLook");
    }

    ~GeneralInput()
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

    // KeyboardInput
    private readonly InputActionMap m_KeyboardInput;
    private IKeyboardInputActions m_KeyboardInputActionsCallbackInterface;
    private readonly InputAction m_KeyboardInput_ForwardBackwardMovement;
    private readonly InputAction m_KeyboardInput_SidewaysMovement;
    public struct KeyboardInputActions
    {
        private GeneralInput m_Wrapper;
        public KeyboardInputActions(GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForwardBackwardMovement => m_Wrapper.m_KeyboardInput_ForwardBackwardMovement;
        public InputAction @SidewaysMovement => m_Wrapper.m_KeyboardInput_SidewaysMovement;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardInputActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardInputActions instance)
        {
            if (m_Wrapper.m_KeyboardInputActionsCallbackInterface != null)
            {
                ForwardBackwardMovement.started -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnForwardBackwardMovement;
                ForwardBackwardMovement.performed -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnForwardBackwardMovement;
                ForwardBackwardMovement.canceled -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnForwardBackwardMovement;
                SidewaysMovement.started -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnSidewaysMovement;
                SidewaysMovement.performed -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnSidewaysMovement;
                SidewaysMovement.canceled -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnSidewaysMovement;
            }
            m_Wrapper.m_KeyboardInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                ForwardBackwardMovement.started += instance.OnForwardBackwardMovement;
                ForwardBackwardMovement.performed += instance.OnForwardBackwardMovement;
                ForwardBackwardMovement.canceled += instance.OnForwardBackwardMovement;
                SidewaysMovement.started += instance.OnSidewaysMovement;
                SidewaysMovement.performed += instance.OnSidewaysMovement;
                SidewaysMovement.canceled += instance.OnSidewaysMovement;
            }
        }
    }
    public KeyboardInputActions @KeyboardInput => new KeyboardInputActions(this);

    // MouseInput
    private readonly InputActionMap m_MouseInput;
    private IMouseInputActions m_MouseInputActionsCallbackInterface;
    private readonly InputAction m_MouseInput_VerticalLook;
    private readonly InputAction m_MouseInput_HorizontalLook;
    public struct MouseInputActions
    {
        private GeneralInput m_Wrapper;
        public MouseInputActions(GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @VerticalLook => m_Wrapper.m_MouseInput_VerticalLook;
        public InputAction @HorizontalLook => m_Wrapper.m_MouseInput_HorizontalLook;
        public InputActionMap Get() { return m_Wrapper.m_MouseInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseInputActions set) { return set.Get(); }
        public void SetCallbacks(IMouseInputActions instance)
        {
            if (m_Wrapper.m_MouseInputActionsCallbackInterface != null)
            {
                VerticalLook.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnVerticalLook;
                VerticalLook.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnVerticalLook;
                VerticalLook.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnVerticalLook;
                HorizontalLook.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnHorizontalLook;
                HorizontalLook.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnHorizontalLook;
                HorizontalLook.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnHorizontalLook;
            }
            m_Wrapper.m_MouseInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                VerticalLook.started += instance.OnVerticalLook;
                VerticalLook.performed += instance.OnVerticalLook;
                VerticalLook.canceled += instance.OnVerticalLook;
                HorizontalLook.started += instance.OnHorizontalLook;
                HorizontalLook.performed += instance.OnHorizontalLook;
                HorizontalLook.canceled += instance.OnHorizontalLook;
            }
        }
    }
    public MouseInputActions @MouseInput => new MouseInputActions(this);
    public interface IKeyboardInputActions
    {
        void OnForwardBackwardMovement(InputAction.CallbackContext context);
        void OnSidewaysMovement(InputAction.CallbackContext context);
    }
    public interface IMouseInputActions
    {
        void OnVerticalLook(InputAction.CallbackContext context);
        void OnHorizontalLook(InputAction.CallbackContext context);
    }
}
