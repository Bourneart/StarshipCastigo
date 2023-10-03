using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicAudioManager : MonoBehaviour
{
    public static MusicAudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        InitializeManager();
    }

    private void InitializeManager()
    {

    }
}
