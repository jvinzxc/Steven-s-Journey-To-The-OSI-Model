using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSound;

    public AudioClip music;
    public AudioClip click;
    
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }


    private void Start()
    {
        musicSource.clip = music;
        musicSource.Play();
    }

    public void ButtonClickSound()
    {
        SFXSound.clip = click;
        SFXSound.Play();

    }
}
