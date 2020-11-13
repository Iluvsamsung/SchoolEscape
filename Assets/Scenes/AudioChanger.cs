using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;

public class AudioChanger
{
	public AudioMixer masterMixer;
	public Slider audioSlider;

	public void AudioControl()
    {
		float sound = audioSlider.value;

		if (sound == -40f) masterMixer.SetFloat("MasterVolume", -80);
		else masterMixer.SetFloat("masterVolume", sound);
    }
}
