using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloInteractive.XR.HoloKit.iOS;

public class HolokitEstimateLightManager : MonoBehaviour
{
    //HoloKitLightEstimator _lightEstimator;
    Light _Light;
    public float MainLightMultipier = 2;
    public float AmbientLightMultipier = 4;

    private void Awake()
    {
        _Light = GetComponent<Light>();

    }

    void Start()
    {
        //_lightEstimator = FindObjectOfType<HoloKitLightEstimator>();
    }
    private void Update()
    {
        SetLightValues();
    }

    void SetLightValues()
    {
        //if (_lightEstimator.AverageBrightness.HasValue)
        //{
        //    _Light.intensity = _lightEstimator.AverageBrightness.Value*2;
        //    RenderSettings.ambientIntensity = _lightEstimator.AverageBrightness.Value*4;
        //}
        //if (_lightEstimator.AverageColorTemperature.HasValue)
        //{
        //    _Light.colorTemperature =  _lightEstimator.AverageColorTemperature.Value;
        //}
    }
}
