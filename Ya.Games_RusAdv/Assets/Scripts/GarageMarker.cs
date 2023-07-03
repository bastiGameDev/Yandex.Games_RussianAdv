using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class GarageMarker : MonoBehaviour
{
    public TextMeshProUGUI _textMesh;
    [SerializeField] private TextMeshProUGUI _textHint;

    [SerializeField] private AudioSource doomerMusic;

    private bool flagMusic = false;
    private bool isMusicPlayed = false;

    private void Update()
    {
        if (flagMusic && Input.GetKeyDown(KeyCode.R))
        {
            if (!isMusicPlayed) 
            {
                doomerMusic.Play();
                isMusicPlayed = true;
            }
            else
            {
                doomerMusic.Pause();
                isMusicPlayed = false;
            }
                
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        _textMesh.text = "Нажми 'Е'";

    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            flagMusic = true;
            Transform childToHide = transform.Find("MarkerGarage");
                childToHide.gameObject.SetActive(false);

            gameObject.GetComponent<BoxCollider>().enabled = false;

            //gameObject.SetActive(false);
            _textMesh.text = "Ты забрал наушники. Направляйся в магазин (за гаражами направо) и наслаждайся прогулкой";
            _textHint.text = "Используй клавишу 'R' для воспроизведения/паузы музыки";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        _textMesh.text = "Иди в свой гараж";
    }

    
}
