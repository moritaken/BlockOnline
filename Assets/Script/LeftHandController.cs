using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandController : MonoBehaviour
{

    [SerializeField]
    private Transform rig;

    private Valve.VR.EVRButtonId touchpad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObject.index); } }
    private SteamVR_TrackedObject trackedObject;

    private Vector2 axis = Vector2.zero;

    void Start()
    {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
        if (trackedObject == null)
        {
            trackedObject = gameObject.AddComponent<SteamVR_TrackedObject>();
        }
    }

    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        var device = SteamVR_Controller.Input((int)trackedObject.index);

        //タッチパッド移動
        if (controller.GetTouch(touchpad))
        {
            axis = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0);

            if (rig != null)
            {
                rig.position += ((transform.right * axis.x) + (transform.forward * axis.y)) * Time.deltaTime * 3;
            }
        }

    }
}