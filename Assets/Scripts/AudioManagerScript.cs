using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioManagerScript instance;

    void Awake()
    {
        // �V�[������AudioManager���܂�������΁A���̃I�u�W�F�N�g��AudioManager�Ƃ��Đݒ�
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // �V�[�����܂����ł��j������Ȃ��悤�ɂ���
        }
        // ���ł�AudioManager�����݂���ꍇ�́A�V��������j�����ďd����h��
        else
        {
            Destroy(gameObject);
        }
    }
}