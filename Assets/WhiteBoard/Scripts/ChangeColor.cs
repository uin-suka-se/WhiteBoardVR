using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour
{
    [SerializeField]
    private GameObject whiteboard;
    private Renderer whiteboardRenderer;

    // Start is called before the first frame update
    void Start()
    {
        whiteboardRenderer = whiteboard.GetComponent<Renderer>();

        // Mengambil referensi ke setiap tombol secara langsung
        Button button1 = GameObject.Find("button1").GetComponent<Button>();
        Button button2 = GameObject.Find("button2").GetComponent<Button>();
        Button button3 = GameObject.Find("button3").GetComponent<Button>();
        Button button4 = GameObject.Find("button4").GetComponent<Button>();
        Button button5 = GameObject.Find("button5").GetComponent<Button>();
        Button button6 = GameObject.Find("button6").GetComponent<Button>();

        // Menambahkan listener ke masing-masing tombol
        button1.onClick.AddListener(() => ChangeWhiteBoardColor(Color.black));
        button2.onClick.AddListener(() => ChangeWhiteBoardColor(Color.green));
        button3.onClick.AddListener(() => ChangeWhiteBoardColor(new Color(139f / 255f, 69f / 255f, 19f / 255f)));
        button4.onClick.AddListener(() => ChangeWhiteBoardColor(Color.yellow));
        button5.onClick.AddListener(() => ChangeWhiteBoardColor(Color.white));
        button6.onClick.AddListener(() => ChangeWhiteBoardColor(new Color(128f / 255f, 128f / 255f, 128f / 255f)));
    }

    // Mengubah warna papan tulis sesuai permintaan
    private void ChangeWhiteBoardColor(Color desiredColor)
    {
        SetWhiteBoardColor(desiredColor);
    }

    // Mengatur warna papan tulis
    private void SetWhiteBoardColor(Color desiredColor)
    {
        whiteboardRenderer.material.SetColor("_Color", desiredColor);
    }

    // Mendapatkan warna yang sesuai dengan indeks tombol
    private Color GetButtonColor(int index)
    {
        switch (index)
        {
            case 1:
                return Color.black;
            case 2:
                return Color.green;
            case 3:
                 return new Color(139f / 255f, 69f / 255f, 19f / 255f);
            case 4:
                return Color.yellow;
            case 5:
                return Color.white;
            case 6:
                return new Color(128f / 255f, 128f / 255f, 128f / 255f);
            default:
                return Color.white; // Default warna putih jika indeks tidak valid
        }
    }
}
