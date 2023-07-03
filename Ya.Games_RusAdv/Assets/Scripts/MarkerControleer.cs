using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MarkerControleer : MonoBehaviour
{
    public TextMeshProUGUI _textMesh;
    [SerializeField] private AudioSource trashSound;

    private void Start()
    {
        _textMesh.text = "Выкинь мусор";
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
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        _textMesh.text = "Выкинь мусор";
    }
}
