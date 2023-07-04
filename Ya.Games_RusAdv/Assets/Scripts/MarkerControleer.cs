using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MarkerControleer : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdFullScreen();

    public TextMeshProUGUI _textMesh;
    [SerializeField] private AudioSource trashSound;
    [SerializeField] private GameObject nextMarker;    
    

    private void Start()
    {       
        _textMesh.text = "Выкинь мусор";        

        Debug.Log("AD SHOWED");

        ShowAdFullScreen();
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
            Debug.Log("Pressed E");
            trashSound.Play();
            gameObject.SetActive(false);          
            _textMesh.text = "Иди в свой гараж";
            nextMarker.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        _textMesh.text = "Выкинь мусор";
    }
}
