using System;
using UnityEngine;
using UnityEngine.Audio;
public class audioMixerInitalizer : MonoBehaviour
{
    public AudioMixer audioMixer;
    void start()
    {
        audioMixer = Resources.Load("MasterMixer") as AudioMixer;
    }
    public AudioMixerGroup[] audioMixGroup
    {
        get
        {
            return audioMixer.FindMatchingGroups("Master");
            ;
        }
    }
}

