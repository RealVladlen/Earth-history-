using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    public void ExplosionSound()
    {
        _source.Play();
    }
}
