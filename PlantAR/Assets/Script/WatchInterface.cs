using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.Rendering;
using UnityEngine.XR;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif


public enum State
{
    Normal,
    Left,
    Right,
    Back,
    Foot
}


public class WatchInterface : MonoBehaviour
{
    public HandType handType;
    public static State state;

    //Stores what kind of characteristics we¡¯re looking for with our Input Device when we search for it later
    [HideInInspector] public InputDeviceCharacteristics inputDeviceCharacteristics;

    //Stores the InputDevice that we¡¯re Targeting once we find it in InitializeHand()
    private InputDevice _targetDevice;

    //The event called by watch
    public static event UnityAction NormalEvent = delegate { };
    public static event UnityAction LeftEvent = delegate { };
    public static event UnityAction RightEvent = delegate { };

    //Watch UI element
    [SerializeField] private GameObject watchCanvas;
    private bool watchState = false;
    //Each side image
    private Sprite selectedSprite;
    [SerializeField] private Color canvasColor;
    [SerializeField] private GameObject leftCanvas;
    [SerializeField] private GameObject rightCanvas;
    [SerializeField] private GameObject normalCanvas;

    [SerializeField] private Sprite leftUnselect;
    [SerializeField] private Sprite rightUnselect;
    [SerializeField] private Sprite normalUnselect;

    [SerializeField] private Sprite leftSelect;
    [SerializeField] private Sprite rightSelect;
    [SerializeField] private Sprite normalSelect;

    //Hand Model Name String
    [SerializeField] private string leftHandName = "LeftHand(Clone)";
    [SerializeField] private string rightHandName = "RightHandProto(Clone)";


    #region Editor
#if UNITY_EDITOR

#endif
    #endregion

    private void Awake()
    {
        selectedSprite = Resources.Load("Icon") as Sprite;
    }

    void Start()
    {
        InitializeHand();

        //Set the start state as normal
        NormalEvent.Invoke();
        state = State.Normal;
        normalCanvas.GetComponent<Image>().sprite = normalSelect;
    }

    private void InitializeHand()
    {
        GameObject spawnedHand;

        if (handType == HandType.Left)
        {
            inputDeviceCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
            spawnedHand = GameObject.Find(leftHandName);
        }
        else
        {
            inputDeviceCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
            spawnedHand = GameObject.Find(rightHandName);
        }


        List<InputDevice> devices = new List<InputDevice>();
        //Call InputDevices to see if it can find any devices with the characteristics we¡¯re looking for
        InputDevices.GetDevicesWithCharacteristics(inputDeviceCharacteristics, devices);

        //Our hands might not be active and so they will not be generated from the search.
        //We check if any devices are found here to avoid errors.
        if (devices.Count > 0)
        {

            _targetDevice = devices[0];
            //_handAnimator = spawnedHand.GetComponent<Animator>();
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Since our target device might not register at the start of the scene, we continously check until one is found.
        if (!_targetDevice.isValid)
        {
            InitializeHand();
        }
        else
        {
            //Active the watch canvas
            JoystickPressed();

            //Get the joystick value to set the platform
            if (watchState)
            {
                JoyStickValue();
            }
        }
    }

    //Watch Window show
    void JoystickPressed()
    {
        _targetDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool isPressed);
        if (isPressed)
        {
            watchState = true;
        }
        else
        {
            watchState = false;
        }
        watchCanvas.SetActive(watchState);
    }


    void JoyStickValue()
    {
        _targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 JoystickValue);
        _targetDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool trigger);

        //Normal State
        if (JoystickValue.x == 0 && JoystickValue.y == 0)
        {
            normalCanvas.GetComponent<Image>().color = canvasColor;

            rightCanvas.GetComponent<Image>().color = Color.white;
            leftCanvas.GetComponent<Image>().color = Color.white;

            if (state != State.Normal && trigger)
            {
                normalCanvas.GetComponent<Image>().sprite = normalSelect;
                rightCanvas.GetComponent<Image>().sprite = rightUnselect;
                leftCanvas.GetComponent<Image>().sprite = leftUnselect;

                NormalEvent.Invoke();
                state = State.Normal;
                Debug.Log("NormalEvent");
            }

        }
        else if (JoystickValue.x > 0)
        {
            //Right State
            if (JoystickValue.y > 0)
            {
                rightCanvas.GetComponent<Image>().color = canvasColor;

                normalCanvas.GetComponent<Image>().color = Color.white;
                leftCanvas.GetComponent<Image>().color = Color.white;

                if (state != State.Right && trigger)
                {
                    normalCanvas.GetComponent<Image>().sprite = normalUnselect;
                    rightCanvas.GetComponent<Image>().sprite = rightSelect;
                    leftCanvas.GetComponent<Image>().sprite = leftUnselect;

                    RightEvent.Invoke();
                    state = State.Right;
                    Debug.Log("RightEvent");
                }

            }
        }
            //Left State
            else
            {
                leftCanvas.GetComponent<Image>().color = canvasColor;

                rightCanvas.GetComponent<Image>().color = Color.white;
                normalCanvas.GetComponent<Image>().color = Color.white;

                if (state != State.Left && trigger)
                {
                    normalCanvas.GetComponent<Image>().sprite = normalUnselect;
                    rightCanvas.GetComponent<Image>().sprite = rightUnselect;
                    leftCanvas.GetComponent<Image>().sprite = leftSelect;

                    LeftEvent.Invoke();
                    state = State.Left;
                    Debug.Log("LeftEvent");
                }
            }
        }
    }
