using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class settings_menu : MonoBehaviour {

    public AudioMixer master_mixer;

    public Text Button_txt;

    private int TapCount = 0;

	// Use this for initialization
	void Start ()
    {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //volume
    public void Volume_Bar(float volume)
    {
        master_mixer.SetFloat("volume", volume);
    }

    //Graphics Quality
    public void Graphics_quality()
    {
        TapCount++;
        if(TapCount == 4)
        {
            TapCount = 0;
        }

        switch(TapCount)
        {
            case 0:
                Button_txt.text = "Low";
                QualitySettings.SetQualityLevel(0);
                break;
            case 1:
                Button_txt.text = "Medium";
                QualitySettings.SetQualityLevel(1);
                break;
            case 2:
                Button_txt.text = "High";
                QualitySettings.SetQualityLevel(2);
                break;
            case 3:
                Button_txt.text = "Ultra";
                QualitySettings.SetQualityLevel(3);
                break;
        }
    }

    //Fullscreen Toggle
    public void Fullscreen_toggle(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
