using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vibratePhone : MonoBehaviour
{
    public void VibratePhone()
    {
#if UNITY_ANDROID
        Handheld.Vibrate();
#endif
    }
}
