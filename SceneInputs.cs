// GENERATED AUTOMATICALLY FROM 'Assets/Digiteknik/SceneInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Digiteknik
{
    public class @SceneInputs : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @SceneInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""SceneInputs"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""795776d7-6c9c-4790-bd94-e94143aea722"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""7bab66a5-50fb-4b56-8798-56d5921477ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SkubBold"",
                    ""type"": ""Value"",
                    ""id"": ""d7ec2334-a7b8-437e-84d4-500e885f01ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6a6a8b60-ee9b-4450-955f-e798840215b3"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b7ca9bb-aec7-4d5e-9351-0372e6284c7a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""30a644ed-f7a3-4633-bbe8-6e1ab0156b80"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fb9c4ebc-3e47-4bfd-8111-08fb7ccc3ac8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""09849e99-5bd0-4817-be8c-d90d47af681c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06698e81-9767-47b4-91a2-6c373af1683b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c97481b3-75df-4fcd-aa45-6ba036e2d2f9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Grow = m_Gameplay.FindAction("Grow", throwIfNotFound: true);
            m_Gameplay_SkubBold = m_Gameplay.FindAction("SkubBold", throwIfNotFound: true);
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
        private readonly InputAction m_Gameplay_Grow;
        private readonly InputAction m_Gameplay_SkubBold;
        public struct GameplayActions
        {
            private @SceneInputs m_Wrapper;
            public GameplayActions(@SceneInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Grow => m_Wrapper.m_Gameplay_Grow;
            public InputAction @SkubBold => m_Wrapper.m_Gameplay_SkubBold;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @Grow.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                    @Grow.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                    @Grow.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                    @SkubBold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkubBold;
                    @SkubBold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkubBold;
                    @SkubBold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkubBold;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Grow.started += instance.OnGrow;
                    @Grow.performed += instance.OnGrow;
                    @Grow.canceled += instance.OnGrow;
                    @SkubBold.started += instance.OnSkubBold;
                    @SkubBold.performed += instance.OnSkubBold;
                    @SkubBold.canceled += instance.OnSkubBold;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);
        public interface IGameplayActions
        {
            void OnGrow(InputAction.CallbackContext context);
            void OnSkubBold(InputAction.CallbackContext context);
        }
    }
}
