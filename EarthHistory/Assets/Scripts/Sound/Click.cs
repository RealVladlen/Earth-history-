using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    public void ClickSound()
    {
        _source.Play();
    }
}
