using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    public AudioSource source;
    public bool loop;
    public void SetSource(AudioSource _source)
    {
        source = _source;
        source.clip = clip;
        source.loop = loop;
    }

}


public class Soundplayer : MonoBehaviour
{
    [SerializeField]
    public Sound[] sounds;

    void start()
    {
        AudioMixer mixer = Resources.Load<AudioMixer>("MasterMixer");

        AudioMixerGroup[] audioMixGroup = mixer.FindMatchingGroups("Master");

        for(int i = 0; i< sounds.Length; i++)
        {
            GameObject soundObject = new GameObject("오디오 파일 이름:" + i + "=" + sounds[i].name);
            sounds[i].SetSource(soundObject.AddComponent<AudioSource>());
            sounds[i].source.outputAudioMixerGroup = audioMixGroup[0];
            
        }
    }
}
