using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
[RequireComponent(typeof(RawImage), typeof(VideoPlayer), typeof(AudioSource))]
public class videoScript : MonoBehaviour
{
    RawImage image;
    VideoPlayer player;
    void Awake()
    {
        image = GetComponent<RawImage>();
        player = GetComponent<VideoPlayer>();
        var source = GetComponent<AudioSource>();
        source.volume = 0.01f;
        player.EnableAudioTrack(0, true);
        player.SetTargetAudioSource(0, source);
    }
    void Update()
    {
        if (player.isPrepared)
        {
            image.texture = player.texture;
        }
    }
}