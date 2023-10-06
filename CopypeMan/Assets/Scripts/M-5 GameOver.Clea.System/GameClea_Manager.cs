using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClea_Manager : MonoBehaviour
{
    // AudioSourceの参照
    [SerializeField] private AudioSource audioSource;

    private void Start()
    {
        // Soundを止める
        audioSource.Stop();
    }
}
