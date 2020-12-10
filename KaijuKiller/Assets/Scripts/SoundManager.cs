using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource deathSound;
    [SerializeField]
    private AudioSource coinSound;
    [SerializeField]
    private AudioSource boostSound;
    
    public void PlayDeath()
    {
        deathSound.Play();
    }
    public void PlayCoin()
    {
        coinSound.Play();
    }
    public void PlayBoost()
    {
        boostSound.Play();
    }
}
