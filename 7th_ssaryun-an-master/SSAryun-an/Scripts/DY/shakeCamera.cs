using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeCamera : MonoBehaviour
{
    public void Do(Canvas canvas)
        //public void Do(Camera camera)
    {
        if (!mIsShake)
        {
            mOriginPos = GetComponent<Canvas>().transform.localPosition;

            mShakeDuration = m_ShakeDuration;
            mIsShake = true;
        }
    }

    private void Update()
    {
        if (mIsShake)
        {
            if (mShakeDuration > 0)
            {
                transform.localPosition = GetPositionByDirection();

                mShakeDuration -= Time.deltaTime;
            }
            else
            {
                transform.localPosition = mOriginPos;

                mShakeDuration = 0;
                mIsShake = false;
            }
        }
    }

    private Vector3 GetPositionByDirection()
    {
        Vector3 pos = Vector3.zero;

        switch (m_Direction)
        {
            case eDirection.LeftRight:
                pos = mOriginPos + (Random.insideUnitSphere * m_ShakeAmout);
                pos.y = 0;
                pos.z = mOriginPos.z;
                break;

            case eDirection.TopDown:
                pos = mOriginPos + (Random.insideUnitSphere * m_ShakeAmout);
                pos.x = 0;
                pos.z = mOriginPos.z;
                break;

            case eDirection.Random:
                pos = mOriginPos + (Random.insideUnitSphere * m_ShakeAmout);
                break;
        }

        return pos;
    }

    [SerializeField] private eDirection m_Direction = eDirection.LeftRight;
    [SerializeField] private float m_ShakeDuration = 1f;
    [SerializeField] private float m_ShakeAmout = 2f;

    private float mShakeDuration = 0;

    private Vector3 mOriginPos;

    private bool mIsShake = false;

    public enum eDirection { LeftRight, TopDown, Random }
}
