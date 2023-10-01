using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private AudioSource menuSound;
    [SerializeField] private Slider musicVolume;
    [SerializeField] private Text musicVolumeValue;

    [Header("Keys")]
    [SerializeField] private string saveVolumeValue;

    [Header("Tags")]
    [SerializeField] private string sliderTag;
    [SerializeField] private string textVolumeValueTag;

    [Header("Parameters")]
    [SerializeField] private float volumeValue;

    private void LateUpdate()
    {
        
    }
}
