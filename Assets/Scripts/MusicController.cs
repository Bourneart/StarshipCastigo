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

    private void Awake()
    {
        if (PlayerPrefs.HasKey(this.saveVolumeValue))
        {
            this.volumeValue = PlayerPrefs.GetFloat(this.saveVolumeValue);
            this.menuSound.volume = 0.5f;

            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
            if(sliderObj != null )
            {
                this.musicVolume = sliderObj.GetComponent<Slider>();
                this.musicVolume.value = this.volumeValue;
            }
        }
        else
        {
            this.volumeValue = 0.5f;
            PlayerPrefs.SetFloat(this.saveVolumeValue, this.volumeValue);
            this.menuSound.volume = this.volumeValue;
        }
    }

    private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null )
        {
            this.musicVolume = sliderObj.GetComponent<Slider>();
            this.volumeValue = musicVolume.value;

            if (menuSound.volume != this.volumeValue)
            {
                PlayerPrefs.SetFloat(this.saveVolumeValue, this.volumeValue);
            }

            GameObject textObj = GameObject.FindWithTag(this.textVolumeValueTag);
            if(textObj != null)
            {
                this.musicVolumeValue = textObj.GetComponent<Text>();
                this.musicVolumeValue.text = Mathf.Round(f: this.volumeValue * 100) + "%";
            }
        }
        this.menuSound.volume = this.volumeValue;
    }
}
