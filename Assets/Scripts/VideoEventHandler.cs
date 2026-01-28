using UnityEngine;
using UnityEngine.Video; // Bắt buộc phải có để dùng VideoPlayer

public class VideoEventHandler : MonoBehaviour
{
    private VideoPlayer vPlayer;

    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();

        // Đăng ký sự kiện: Khi video chạy đến điểm kết thúc
        vPlayer.loopPointReached += OnVideoFinished;

        Debug.Log("Đã đăng ký sự kiện kết thúc video.");
    }

    // Hàm này sẽ tự động chạy khi video kết thúc
    void OnVideoFinished(VideoPlayer source)
    {
        Debug.Log("Video đã kết thúc thành công!");

        // Yêu cầu Lab 7: Hiển thị UI hoặc thông báo
        // Ví dụ: Bạn có thể thêm code chuyển Scene tại đây
        // UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }
}