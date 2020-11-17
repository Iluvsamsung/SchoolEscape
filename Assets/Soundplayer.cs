using UnityEngine;
using UnityEngine.Audio;


// private static AudioMixer Mixer = Resources.Load<AudioMixer>("MasterMixer");
// public readonly AudioMixerGroup[] audioMixGroup = Mixer.FindMatchingGroups("Master");



[System.Serializable]
    public class Sound 
    {
        private AudioMixer audioMixer;
        private AudioMixerGroup[] audioMixGroup;

        private AudioMixerGroup init(AudioMixer _audioMixer)
        {
            audioMixGroup = _audioMixer.FindMatchingGroups("master");
            return audioMixGroup[0];
        }

        void start()
        {
            audioMixer = Resources.Load("MasterMixer") as AudioMixer;
            init(audioMixer);
        }

        public string name;
        public AudioClip clip;
        public bool loop;
        private AudioSource source;

        public void SetSource(AudioSource _source)
        {
            _source.outputAudioMixerGroup = audioMixGroup[0];
            _source.clip = clip;
            _source.loop = loop;
        }

    }


    public class Soundplayer : MonoBehaviour
    {
       [SerializeField]
        public Sound[] sounds;

        void start()
        {


            for (int i = 0; i < sounds.Length; i++)
            {
                GameObject soundObject = new GameObject("오디오 파일 이름:" + i + "=" + sounds[i].name);
                soundObject.transform.SetParent(this.transform);
                sounds[i].SetSource(soundObject.AddComponent<AudioSource>());

            }
        }
    }
