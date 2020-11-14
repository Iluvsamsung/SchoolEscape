using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;

public class AudioChanger : MonoBehaviour
{
	public AudioMixer MasterMixer;
	public Slider audioSlider;

	public void AudioControl()
    {
		float sound = audioSlider.value;

		if (sound == -40f) MasterMixer.SetFloat("Master", -80f);
		else MasterMixer.SetFloat("Master", sound);
    }
}
