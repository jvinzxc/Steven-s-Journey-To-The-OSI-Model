using UnityEngine;
using UnityEngine.Playables;

public class TimelineAndDialogue : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject gameObjectToActivate;

    private bool timelineFinished = false;

    void Start()
    {
        // Subscribe to the timeline's finished event
        timeline.stopped += OnTimelineFinished;
    }

    void OnTimelineFinished(PlayableDirector director)
    {
        // Timeline has finished
        timelineFinished = true;
    }

    void Update()
    {
        // Check if the timeline has finished and activate the GameObject
        if (timelineFinished && !gameObjectToActivate.activeSelf)
        {
            gameObjectToActivate.SetActive(true);
        }
    }
}
