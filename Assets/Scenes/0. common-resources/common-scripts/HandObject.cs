using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloInteractive.XR.HoloKit.iOS;

public class HandObject : MonoBehaviour
{
    enum Type {
        LiteHandTracker,
        HandTracker
    }

    [SerializeField] Type _type = Type.HandTracker;
    [SerializeField] Transform _joint;

    private static HandObject _instance;

    public static HandObject Instance { get { return _instance;  } }

    public bool IsHandValid = false;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    void Start()
    {

    }

    private void Update()
    {
        switch (_type)
        {
            case Type.LiteHandTracker:
                //IsHandValid = FindObjectOfType<LiteHandTrackingManager>().IsHandValid;
                IsHandValid = true;
                break;
            case Type.HandTracker:
                if(FindObjectOfType<HandTrackingManager>().HandCount != 0)
                {
                    IsHandValid = true;
                }
                else {
                    IsHandValid = false;
                }
                
                break;
        }

        if (IsHandValid)
        {
            transform.position = _joint.position;
        }
        else
        {
            transform.position = FindObjectOfType<HoloInteractive.XR.HoloKit.HoloKitCameraManager>().CenterEyePose.position + Vector3.up * -1f;
        }
    }
}
