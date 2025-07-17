using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioManagerScript instance;

    void Awake()
    {
        // シーン内にAudioManagerがまだ無ければ、このオブジェクトをAudioManagerとして設定
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // シーンをまたいでも破棄されないようにする
        }
        // すでにAudioManagerが存在する場合は、新しい方を破棄して重複を防ぐ
        else
        {
            Destroy(gameObject);
        }
    }
}