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
        //anim.Play("click_wrong"); //지금 바로 재생.
        //if (anim.IsPlaying("click_wrong")) // 다음 애니메이션이 재생중이면 true.
        //    anim.Stop();// 즉각 재생중인 모든 애니메이션 멈춤
        //anim.wrapMode = WrapMode.Loop;// 애니메이션 재생 모드

        //anim.cullingType = AnimationCullingType.AlwaysAnimate; //카메라 밖 재생여부
    }

    public void clickWrong()
    {

    }

}
