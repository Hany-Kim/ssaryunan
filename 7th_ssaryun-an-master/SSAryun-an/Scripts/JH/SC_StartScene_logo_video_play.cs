using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SC_StartScene_logo_video_play : MonoBehaviour
{
    private VideoPlayer start_logo_video_play;

    private void Awake()
    {
        start_logo_video_play = GetComponent<VideoPlayer>();
        start_logo_video_play.Play();
    }
}
