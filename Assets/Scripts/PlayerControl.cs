// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Cat"",
            ""id"": ""1fc61138-0542-4551-8171-5aa352668b12"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a484c918-4d9d-49b1-a614-b870c76ab02c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""ba275d11-094b-4147-b762-559351c96fd5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""319c651d-c041-4e08-8c2d-3923d474188e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3b22e88-6625-4ab3-9376-57ccbe808a23"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1ee36a8-8b48-417c-998f-a636286e6370"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a5015546-0478-4e50-89e1-d8f1ead5f931"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""20c71f46-6416-4428-b0ed-ac5f6a627084"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""c5b30d82-c03c-48f7-9ecf-53a2bc3bfa76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6d4504a7-73ce-43e7-ac7b-394e770bc8cf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Cat
        m_Cat = asset.FindActionMap("Cat", throwIfNotFound: true);
        m_Cat_Move = m_Cat.FindAction("Move", throwIfNotFound: true);
        // Menus
        m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
        m_Menus_Select = m_Menus.FindAction("Select", throwIfNotFound: true);
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

    // Cat
    private readonly InputActionMap m_Cat;
    private ICatActions m_CatActionsCallbackInterface;
    private readonly InputAction m_Cat_Move;
    public struct CatActions
    {
        private @PlayerControl m_Wrapper;
        public CatActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Cat_Move;
        public InputActionMap Get() { return m_Wrapper.m_Cat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CatActions set) { return set.Get(); }
        public void SetCallbacks(ICatActions instance)
        {
            if (m_Wrapper.m_CatActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CatActions @Cat => new CatActions(this);

    // Menus
    private readonly InputActionMap m_Menus;
    private IMenusActions m_MenusActionsCallbackInterface;
    private readonly InputAction m_Menus_Select;
    public struct MenusActions
    {
        private @PlayerControl m_Wrapper;
        public MenusActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Menus_Select;
        public InputActionMap Get() { return m_Wrapper.m_Menus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
        public void SetCallbacks(IMenusActions instance)
        {
            if (m_Wrapper.m_MenusActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_MenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public MenusActions @Menus => new MenusActions(this);
    public interface ICatActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnSelect(InputAction.CallbackContext context);
    }
}
