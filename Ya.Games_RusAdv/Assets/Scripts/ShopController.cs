using TMPro;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public TextMeshProUGUI _textMesh;

    [SerializeField] private GameObject nextMarker;

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
            
            gameObject.SetActive(false);
            _textMesh.text = "Всё! Направляйся домой! Наслаждайся двором!";
            nextMarker.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        _textMesh.text = "Ты забрал наушники. Направляйся в магазин (за гаражами направо) и наслаждайся прогулкой";
    }
}
