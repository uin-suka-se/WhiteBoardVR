using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMarkerColor : MonoBehaviour
{
    [SerializeField]
    private GameObject marker; // Mengubah nama dari whiteboard menjadi marker
    private Renderer markerRenderer;

    // Start is called before the first frame update
    void Start()
    {
        markerRenderer = marker.GetComponent<Renderer>();

        // Mengambil referensi ke setiap tombol secara langsung
        Button Button1 = GameObject.Find("Button1").GetComponent<Button>();
        Button Button2 = GameObject.Find("Button2").GetComponent<Button>();
        Button Button3 = GameObject.Find("Button3").GetComponent<Button>();
        Button Button4 = GameObject.Find("Button4").GetComponent<Button>();

        // Menambahkan listener ke masing-masing tombol
        Button1.onClick.AddListener(() => ChangeMarkerColorTo(Color.black));
        Button2.onClick.AddListener(() => ChangeMarkerColorTo(Color.red));
        Button3.onClick.AddListener(() => ChangeMarkerColorTo(Color.yellow));
        Button4.onClick.AddListener(() => ChangeMarkerColorTo(Color.green));
    }

    // Mengubah warna spidol sesuai permintaan
    private void ChangeMarkerColorTo(Color desiredColor)
    {
        Debug.Log("Changing marker color to: " + desiredColor); // Log untuk debugging
        SetMarkerColor(desiredColor);
    }

    // Mengatur warna spidol
    private void SetMarkerColor(Color desiredColor)
    {
        Debug.Log("Setting marker color to: " + desiredColor); // Log untuk debugging
        markerRenderer.material.SetColor("_Color", desiredColor);
    }

    // Mendapatkan warna yang sesuai dengan indeks tombol
    private Color GetButtonColor(int index)
    {
        switch (index)
        {
            case 1:
                return Color.black;
            case 2:
                return Color.red;
            case 3:
                return Color.yellow;
            case 4:
                return Color.green;
            default:
                return Color.black; // Default warna hitam jika indeks tidak valid
        }
    }
}
