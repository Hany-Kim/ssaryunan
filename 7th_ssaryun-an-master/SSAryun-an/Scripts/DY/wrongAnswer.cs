using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class wrongAnswer : MonoBehaviour
{
    public GameObject popupUI;

    //public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Play()
    {
        Debug.Log("PLAY ANIM");
        //anim.Play("click_wrong"); //���� �ٷ� ���.
        //if (anim.IsPlaying("click_wrong")) // ���� �ִϸ��̼��� ������̸� true.
        //    anim.Stop();// �ﰢ ������� ��� �ִϸ��̼� ����
        //anim.wrapMode = WrapMode.Loop;// �ִϸ��̼� ��� ���

        //anim.cullingType = AnimationCullingType.AlwaysAnimate; //ī�޶� �� �������
    }

    public void clickWrong()
    {

    }

}
