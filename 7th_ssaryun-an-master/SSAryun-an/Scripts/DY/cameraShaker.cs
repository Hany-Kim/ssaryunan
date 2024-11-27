using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShaker : MonoBehaviour
{
    private static cameraShaker instance;
    public static cameraShaker Instance => instance;

    private float shakeTime;
    private float shakeintensity;

    private void Update()
    {
        instance = this;
        //if (Input.GetKeyDown("1"))
        //{
        //    OnShakeCamera(0.1f, 1f);
        //    Debug.Log("ShakeShakeShake");
        //}
    }

    public void OnShakeCamera(float shakeTime=1.0f, float shakeIntensity = 0.1f)
    {
        this.shakeTime = shakeTime;
        this.shakeintensity = shakeIntensity;

        StopCoroutine("ShakeByRotation");
        StartCoroutine("ShakeByRotation");
    }

    private IEnumerator ShakeByPosition()
    {
        Vector3 startPosition = transform.position;

        while (shakeTime > 0.0f)
        {
            transform.position = startPosition + Random.insideUnitSphere * shakeintensity;

            shakeTime -= Time.deltaTime;

            yield return null;
        }
        transform.position = startPosition;
    }

    private IEnumerator ShakeByRotation()
    {
        Vector3 startRotation = transform.eulerAngles;
        float power = 10f;

        while (shakeTime > 0.0f)
        {
            float x = 0;
            float y = 0;
            float z = Random.Range(-1f, 1f);
            transform.rotation = Quaternion.Euler(startRotation + new Vector3(x, y, z) * shakeintensity * power);

            shakeTime -= Time.deltaTime;

            yield return null;
        }

        transform.rotation = Quaternion.Euler(startRotation);
    }

    //public float ShakeAmount;
    //public Canvas canvas;
    //float ShakeTime;
    //Vector3 initPosition;

    //public void VibrateForTime(float time)
    //{
    //    ShakeTime = time;
    //    canvas.renderMode = RenderMode.ScreenSpaceOverlay;
    //}

    //// Start is called before the first frame update
    //void Start()
    //{
    //    Debug.Log("BBB" + transform.position);
    //    initPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    //    Debug.Log("CCC" + initPosition.x);
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (ShakeTime > 0)
    //    {
    //        transform.position = Random.insideUnitSphere * ShakeAmount + initPosition;
    //        ShakeTime -= Time.deltaTime;
    //    }
    //    else
    //    {
    //        ShakeTime = 0.0f;
    //        transform.position = initPosition;
    //        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
    //    }
    //}
}
