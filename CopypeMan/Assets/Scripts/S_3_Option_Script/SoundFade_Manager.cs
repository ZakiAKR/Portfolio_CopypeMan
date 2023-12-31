using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FedeInが終わったらSoundを流す
public class SoundFade_Manager : MonoBehaviour
{
    //Fade_Managerの参照
    [SerializeField]
    public Fade_Manager fade;

    //AudioSourceの参照
    public AudioSource audioSource;

    private void Start()
    {
        //音量を０に初期化
        audioSource.volume = 0f;
    }

    private void Update()
    {
        //FadeInを判定する
        if (!fade.fadeSystem[0].fadeIn)
        {
            for(int num = 0; num < fade.audioSource.Length; num++) { fade.sound_fadeIn = true; }
        }
    }
}
