using UnityEngine;
[CreateAssetMenu(fileName = "AudioSettings", menuName = "ScriptableObjects/AudioSettings", order = 1)]
public class AudioSettings : ScriptableObject
{
    public float musicVolume;
    public float sfxVolume;
    public float masterVolume;

    public void SetMusic(float music)
    {
        musicVolume = music;
    }

    public void SetSFX(float sfx)
    {
        sfxVolume = sfx;
    }

    public void SetMaster(float master)
    {
        masterVolume = master;
    }
}