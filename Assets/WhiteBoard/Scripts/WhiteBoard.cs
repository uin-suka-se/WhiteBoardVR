using UnityEngine;

public class WhiteBoard : MonoBehaviour
{
    public Texture2D texture; // Texture whiteboard
    public Vector2 textureSize = new Vector2(2048, 2048); // Ukuran texture whiteboard

    void Start()
    {
        var r = GetComponent<Renderer>(); // Mendapatkan komponen Renderer dari GameObject ini
        texture = new Texture2D((int)textureSize.x, (int)textureSize.y); // Inisialisasi texture whiteboard
        r.material.mainTexture = texture; // Terapkan texture ke material utama renderer
    }

    // Metode untuk membersihkan whiteboard
    public void ClearBoard()
    {
        Color32[] colors = new Color32[(int)(textureSize.x * textureSize.y)]; // Buat array warna kosong
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = Color.white; // Atur semua warna menjadi putih
        }
        texture.SetPixels32(colors); // Atur piksel-piksel texture menjadi warna putih
        texture.Apply(); // Terapkan perubahan pada texture
    }
}
