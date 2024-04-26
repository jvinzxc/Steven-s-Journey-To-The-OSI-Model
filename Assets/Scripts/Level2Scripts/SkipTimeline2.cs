using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using System.Linq;

public class SkipTimeline2 : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public int markNum;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SkipScene()
    {
        var timelineAsset = playableDirector.playableAsset as TimelineAsset;
        var markers = timelineAsset.markerTrack.GetMarkers().ToArray();
        playableDirector.Play();
        playableDirector.time = markers[markNum].time;
    }
}
