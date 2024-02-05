using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class MarkerScript : Marker
{
    [SerializeField] private string message = "skipped";
    public PropertyName id => new PropertyName();
    public string Message => message;

   
}
