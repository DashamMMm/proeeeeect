using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class workWithVideo : MonoBehaviour
{

    public VideoPlayer videoPlayer;

    public void rewindForward()
    {
        videoPlayer.time += 5;
    }

    public void rewindBack()
    {
        videoPlayer.time -= 5;
    }
}
