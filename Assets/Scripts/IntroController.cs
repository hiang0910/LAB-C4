using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement; // Cần thiết để chuyển Scene

public class IntroController : MonoBehaviour
{
    public VideoPlayer introVideo;
    public string nextSceneName = "Gameplay"; // Tên của Scene tiếp theo

    void Start()
    {
        // Đăng ký sự kiện: Video kết thúc tự động chuyển Scene
        introVideo.loopPointReached += TransitionToGame;
    }

    // Hàm chuyển Scene
    public void TransitionToGame(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }

    // Hàm dành cho nút Skip (gắn vào sự kiện OnClick của Button)
    public void SkipIntro()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}