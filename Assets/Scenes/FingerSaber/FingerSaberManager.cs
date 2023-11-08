using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using HoloInteractive.XR.HoloKit.iOS;


public class FingerSaberManager : MonoBehaviour
{
    [SerializeField] HandGestureManager _HGM;
    [SerializeField] VisualEffect[] _vfxs = new VisualEffect[5];

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        for (int i = 0; i < 5; i++)
        {
            _vfxs[i].SetVector3("Fixed Axis", _HGM.TipNormals[i]);
            _vfxs[i].transform.position = _HGM.HandTips[i].position;
        }
    }
}
