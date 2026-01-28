using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Biến để tham chiếu tới component AudioSource
    private AudioSource myAudio;

    void Start()
    {
        // Lấy component AudioSource được gắn trên cùng một Object
        myAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Kiểm tra nếu người dùng nhấn phím Space (Dấu cách)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!myAudio.isPlaying) // Nếu nhạc đang không phát thì mới phát
            {
                myAudio.Play();
                Debug.Log("Đang phát âm thanh...");
            }
        }

        // Kiểm tra nếu người dùng nhấn phím S
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (myAudio.isPlaying) // Nếu nhạc đang phát thì mới dừng
            {
                myAudio.Stop();
                Debug.Log("Đã dừng âm thanh.");
            }
        }
    }
}