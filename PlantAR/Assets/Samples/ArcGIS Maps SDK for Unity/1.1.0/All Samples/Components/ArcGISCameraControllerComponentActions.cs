//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/Samples/ArcGIS Maps SDK for Unity/1.1.0/All Samples/Components/ArcGISCameraControllerComponentActions.inputactions
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

namespace Esri.ArcGISMapsSDK.Samples.Components
{
    public partial class @ArcGISCameraControllerComponentActions : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @ArcGISCameraControllerComponentActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""ArcGISCameraControllerComponentActions"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""2c9bcb99-1de2-4daf-9c89-769175e99ba2"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""3761cf8f-23f1-44ca-820e-28b47b3be36f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""0d592f84-62a7-45eb-9648-8fc7d5dc1d10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""f2a0ae8a-49b8-40ef-8d59-493e82dab5e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Up"",
                    ""id"": ""2a57c5e2-e595-4368-957f-b394bc4d26ed"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""456354b5-74f2-4346-a858-b7f7d7239dc6"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b71bc2a8-b29a-4c10-b0af-61d850da1b6c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UpAlt"",
                    ""id"": ""36cf9440-7dd9-4660-a769-8a7da129031a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9725a33c-9c3b-42e5-8a39-91fca5fc139a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""beebb3ee-c53e-4920-8b76-6ef1992c1813"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""b89e36fd-5c85-4f75-8c31-e9a4dc139a9a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9a773c59-f1e2-48cc-a8fb-621375631d19"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b6829142-784a-4480-99c2-d132fec6405c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""4f7cc5e1-057c-4d37-8ff5-3405bb1e2ed6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cd8e3d18-9665-4ca9-86e2-b41ab73eb74a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d45b1afd-b610-46a7-943a-8585ad34e765"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Move
            m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
            m_Move_Up = m_Move.FindAction("Up", throwIfNotFound: true);
            m_Move_Forward = m_Move.FindAction("Forward", throwIfNotFound: true);
            m_Move_Right = m_Move.FindAction("Right", throwIfNotFound: true);
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

        // Move
        private readonly InputActionMap m_Move;
        private IMoveActions m_MoveActionsCallbackInterface;
        private readonly InputAction m_Move_Up;
        private readonly InputAction m_Move_Forward;
        private readonly InputAction m_Move_Right;
        public struct MoveActions
        {
            private @ArcGISCameraControllerComponentActions m_Wrapper;
            public MoveActions(@ArcGISCameraControllerComponentActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Up => m_Wrapper.m_Move_Up;
            public InputAction @Forward => m_Wrapper.m_Move_Forward;
            public InputAction @Right => m_Wrapper.m_Move_Right;
            public InputActionMap Get() { return m_Wrapper.m_Move; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
            public void SetCallbacks(IMoveActions instance)
            {
                if (m_Wrapper.m_MoveActionsCallbackInterface != null)
                {
                    @Up.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnUp;
                    @Up.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnUp;
                    @Up.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnUp;
                    @Forward.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnForward;
                    @Forward.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnForward;
                    @Forward.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnForward;
                    @Right.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnRight;
                    @Right.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnRight;
                    @Right.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnRight;
                }
                m_Wrapper.m_MoveActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Up.started += instance.OnUp;
                    @Up.performed += instance.OnUp;
                    @Up.canceled += instance.OnUp;
                    @Forward.started += instance.OnForward;
                    @Forward.performed += instance.OnForward;
                    @Forward.canceled += instance.OnForward;
                    @Right.started += instance.OnRight;
                    @Right.performed += instance.OnRight;
                    @Right.canceled += instance.OnRight;
                }
            }
        }
        public MoveActions @Move => new MoveActions(this);
        public interface IMoveActions
        {
            void OnUp(InputAction.CallbackContext context);
            void OnForward(InputAction.CallbackContext context);
            void OnRight(InputAction.CallbackContext context);
        }
    }
}
