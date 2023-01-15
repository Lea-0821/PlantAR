using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;
using UnityEngine.Rendering.Universal;


public enum HandType
{
    Left,
    Right
}

[RequireComponent(typeof(CharacterController))]
public class ContinusMoveArcGIS : MonoBehaviour
{
    public XRNode leftInputSource;
    public XRNode rightInputSource;
    private Vector2 leftInputAxis;
    private Vector2 rightInputAxis;
    private CharacterController controller;
    [SerializeField] private float speed;
    [SerializeField] private float upSpeed;
    [SerializeField] private XROrigin XROrigin;
    public LayerMask groundLayer;
    private float fallSpeed;
    private float heightOffset = 0.2f;

    //
    private Vector3 direction;
    private Quaternion headYaw;
    private Vector3 up;


    //Tracking Controller
    [SerializeField] private HandType handType;
    //Stores what kind of characteristics we’re looking for with our Input Device when we search for it later
    [HideInInspector] public InputDeviceCharacteristics inputDeviceCharacteristics;
    //Stores the InputDevice that we’re Targeting once we find it in InitializeHand()
    private InputDevice _targetDevice;
    //Hand Model Name String
    [SerializeField] private string leftHandName;
    [SerializeField] private string rightHandName;


    // Start is called before the first frame update
    void Start()
    {
        InitializeHand();
        controller = GetComponent<CharacterController>();
    }


    private void FixedUpdate()
    {
        FollowHeadset();

        controller.Move(direction * speed * Time.fixedDeltaTime);
        controller.Move(up * upSpeed * Time.fixedDeltaTime);

    }

    void Update()
    {
        //Since our target device might not register at the start of the scene, we continously check until one is found.
        if (!_targetDevice.isValid)
        {
            InitializeHand();
        }
        else
        {
            //Get controller joystick data
            JoystickPressed(handType);
        }


        //InputDevice leftDevice = InputDevices.GetDeviceAtXRNode(leftInputSource);
        //leftDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out leftInputAxis);
        //InputDevice rightDevice = InputDevices.GetDeviceAtXRNode(rightInputSource);
        //rightDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out rightInputAxis);
        //Debug.Log(leftInputAxis);
    }
    void FollowHeadset()
    {
        controller.height = XROrigin.CameraInOriginSpaceHeight + heightOffset;
        Vector3 capsuleCenter = transform.InverseTransformPoint(XROrigin.Camera.transform.position);
        controller.center = new Vector3(capsuleCenter.x, controller.height / 2 + controller.skinWidth, capsuleCenter.z);

        if (handType == HandType.Left)
        {
            //left hand control the horizontal 
            headYaw = Quaternion.Euler(0, XROrigin.Camera.transform.eulerAngles.y, 0);
            direction = headYaw * new Vector3(leftInputAxis.x, 0, leftInputAxis.y);
        }
        else
        {
            //right hand control the verticle
            up = new Vector3(0, rightInputAxis.y, 0);
        }
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
        //Call InputDevices to see if it can find any devices with the characteristics we’re looking for
        InputDevices.GetDevicesWithCharacteristics(inputDeviceCharacteristics, devices);

        //Our hands might not be active and so they will not be generated from the search.
        //We check if any devices are found here to avoid errors.
        if (devices.Count > 0)
        {
            _targetDevice = devices[0];
        }
    }

    void JoystickPressed(HandType handType)
    {
        if(handType == HandType.Left)
        {
            _targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 leftInputAxis);
        }
        else
        {
            _targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 rightInputAxis);
        }

    }



}
