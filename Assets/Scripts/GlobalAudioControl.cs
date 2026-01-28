using UnityEngine;

public class GlobalAudioControl : MonoBehaviour
{
    private bool isMuted = false;

    void Update()
    {
        // Lab 3 yêu cầu phím M để Mute/Unmute
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            // AudioListener.volume điều khiển âm lượng tổng của toàn bộ game (0 đến 1)
            AudioListener.volume = isMuted ? 0 : 1;
            Debug.Log(isMuted ? "Đã Mute" : "Đã Unmute");
        }

        // Lab 3 yêu cầu phím P để Pause/Resume toàn bộ audio
        if (Input.GetKeyDown(KeyCode.P))
        {
            // AudioListener.pause dừng tất cả nguồn phát âm thanh ngay lập tức
            AudioListener.pause = !AudioListener.pause;
            Debug.Log(AudioListener.pause ? "Đã Pause Audio" : "Đã Resume Audio");
        }
    }
}