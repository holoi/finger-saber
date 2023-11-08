# finger-saber
# Changelog

# Abstract

In this project, I create a demo scene to demonstrate the capabilities of Hand-Tracking feature in HoloKit SDK.

# Demos

https://github.com/holoi/finger-saber/assets/52849063/a2e526a5-8b06-480e-8aa6-85406d734083


# Features/How does it work

Our hand-tracking feature provides 21 joints of each hand:
<img width="1082" alt="image" src="https://github.com/holoi/finger-saber/assets/52849063/ab56ab3a-47df-4aec-87f9-a9fc5f3b09b9">


In this scene, i take positions of TIP and IP to calculate approximately directions of each finger. Then, add saber visual effect along the direction:
<img width="1085" alt="image" src="https://github.com/holoi/finger-saber/assets/52849063/9d538372-a771-4e29-909d-6e27a80e8bff">


# System requirements

This project uses HoloKit SDK(version 3.12) and aims to build an app runs on iOS device.
I created and built this project in Unity 2022.3.12f1, I highly recommend you use this version and above to open the project.
Make sure your Unity had install the iOS module:

1. Some features from HoloKit SDK only works on platform of iOS. If you work on other platform, some code may fail to compile, preventing you from entering Play mode and significantly impacting your development experience.
2. Build to an Xcode project needs iOS module.
I built this project to iPhone with Xcode 14.2.

# How to try it
