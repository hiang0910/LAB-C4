using UnityEngine;
using UnityEngine.Video; // Lưu ý: Phải có dòng này để dùng được VideoPlayer

public class VideoControl : MonoBehaviour
{
    private VideoPlayer vPlayer;

    void Start()
    {
        // Lấy component Video Player gắn trên cùng Object
        vPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        // Nhấn phím V để phát video
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!vPlayer.isPlaying)
            {
                vPlayer.Play();
                Debug.Log("Video đang phát...");
            }
        }
    }
}